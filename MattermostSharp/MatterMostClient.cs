using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MattermostSharp.Data;
using MattermostSharp.Models.Channels;
using MattermostSharp.Models.Teams;
using MattermostSharp.Models.Users;
using MattermostSharp.Models.WebSocket;
using MattermostSharp.Users.POST;
using MattermostSharp.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace MattermostSharp
{
    public class MatterMostClient
    {
        protected string domain;//must be secured (https)

        protected MatterMostUser user;
        protected string deviceId;

        private string authToken;
        protected ClientWebSocket ClientWebSocket;
        public MatterMostClient(Uri domain, string device, MatterMostUser user)
        {
            if (domain.Scheme != "https")
                throw new NotSupportedException("Uri scheme must be https ");

            this.domain = "https://" + domain.Host;
            this.user = user;
            this.deviceId = device;
        }


        public async Task<bool> AuthenticateAsync()
        {

            RestClient client = new RestClient(domain);
            var req = new RestRequest(MmEndpoints.V3.Users.Login(), Method.POST);
            LoginModel model = new LoginModel()
            {
                DeviceId = deviceId,
                LoginId = user.UserName,
                Password = user.Password,

            };

            req.AddJsonNetBody(model);
            var restResponse = await client.ExecuteTaskAsync(req);
            if (restResponse.StatusCode != HttpStatusCode.OK)
            {
                return false;
            }

            this.authToken = restResponse.Headers.FirstOrDefault(x => x.Name == "Token")?.Value.ToString();
            LoginResponse r = JsonConvert.DeserializeObject<LoginResponse>(restResponse.Content);

            
            return true;
        }

        public void StartWebSocket(CancellationToken cancellationToken)
        {
            Task wsTask = new Task(async () =>
            {
                this.ClientWebSocket = new ClientWebSocket();
                var uri = new Uri($"{domain.Replace("https:", "wss:")}/{MmEndpoints.V3.Websocket.Main()}");
                
                await ClientWebSocket.ConnectAsync(uri,
                    cancellationToken);
                await ProcessWsAuth(cancellationToken);
                var buffer = new byte[1024];
                while (!cancellationToken.IsCancellationRequested)
                {
                    var segment = new ArraySegment<byte>(buffer);
                    var res = await ClientWebSocket.ReceiveAsync(segment, cancellationToken);
                    if (res.MessageType == WebSocketMessageType.Close)
                    {
                        await ClientWebSocket.CloseAsync(WebSocketCloseStatus.InvalidMessageType, "I don't do binary", CancellationToken.None);
                        return;
                    }

                }
            });
            wsTask.Start();
        }

        private async Task ProcessWsAuth(CancellationToken cancellationToken)
        {
            var authChallenge = new AuthChallenge()
            {
                Seq = 1,
                Action = "authentication_challenge",
                AuthData = new AuthChallenge.Data() {Token = authToken}
            };

            await ClientWebSocket.SendAsync<AuthChallenge>(authChallenge,cancellationToken);
        }


        public async Task<IEnumerable<MiniTeam>> GetMyTeamsAsync()
        {
            var client = GetAuthRestClient();
            var req = new RestRequest(MmEndpoints.V3.Teams.GetUserTeams(), Method.GET);
            var response = await client.ExecuteTaskAsync<List<MiniTeam>>(req);
            return response.Data;
        }

        //public async Task<FullTeam> GetFullTeamsAsync()
        //{
        //    var client = GetAuthRestClient();
        //    var req = new RestRequest(MmEndpoints.V3.Teams.GetAll(), Method.GET);
        //    var response = await client.ExecuteTaskAsync<FullTeam>(req);
        //    return response.Data;
        //}

        public async Task<IEnumerable<Channel>> GetUnjoinedChannelsAsync(MiniTeam team)
        {
            var client = GetAuthRestClient();
            var req = new RestRequest(MmEndpoints.V3.Channels.GetUnjoinedChannel(team.TeamId), Method.GET);
            var response = await client.ExecuteTaskAsync<List<Channel>>(req);
            return response.Data;
        }

        public async Task<IEnumerable<Channel>> GetJoinedChannelAsync(MiniTeam team)
        {
            var client = GetAuthRestClient();
            var req = new RestRequest(MmEndpoints.V3.Channels.GetChannelsForUser(team.TeamId), Method.GET);
            var response = await client.ExecuteTaskAsync<List<Channel>>(req);
            return response.Data;
        }
        private RestClient GetAuthRestClient()
        {
            RestClient client = new RestClient(domain);
            // Override with Newtonsoft JSON Handler
            client.AddHandler("application/json", NewtonsoftJsonSerializer.Default);
            client.AddHandler("text/json", NewtonsoftJsonSerializer.Default);
            client.AddHandler("text/x-json", NewtonsoftJsonSerializer.Default);
            client.AddHandler("text/javascript", NewtonsoftJsonSerializer.Default);
            client.AddHandler("*+json", NewtonsoftJsonSerializer.Default);
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", authToken));
            return client;
        }

    }
}

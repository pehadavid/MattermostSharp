using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MattermostSharp.Data;
using MattermostSharp.Users.POST;
using Newtonsoft.Json;
using RestSharp;

namespace MattermostSharp
{
    public class MatterMostClient
    {
        protected string domain;//must be secured (https)
        protected string team;
        protected MatterMostUser user;
        protected string deviceId;

        private string authToken;
        public MatterMostClient(Uri domain, string team, string device, MatterMostUser user)
        {
            if (domain.Scheme != "https")
                throw new NotSupportedException("Uri scheme must be https ");

            this.domain = "https://" + domain.Host;
            this.team = team;
            this.user = user;
            this.deviceId = device;
        }


        public async Task<bool> AuthenticateAsync()
        {
            
            RestClient client = new RestClient(domain);
            var req = new RestRequest(MMEndpoints.V3.Users.Login(), Method.POST);
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

    }
}

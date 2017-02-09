using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace MattermostSharp.xUnit
{
    public class UnitTest1
    {
        [Fact]
        public async Task TestAuthentOk()
        {
            string username = "pa@nextinpact.com";
            string password = "toto12345";

            MatterMostClient client = new MatterMostClient(new Uri("https://gitlab.mattermost.com"), 
                "dotnetmm", new MatterMostUser(username, password));
            var uat = await client.AuthenticateAsync();
            Assert.True(uat);

        }

        [Fact]
        public async Task TestAuthentNotOk()
        {
            string username = "imjustinvalid@blah.com";
            string password = "toto12345";

            MatterMostClient client = new MatterMostClient(new Uri("https://gitlab.mattermost.com"),  "dotnetmm", new MatterMostUser(username, password));
            var uat = await client.AuthenticateAsync();
            Assert.False(uat);
        }


        [Fact]
        public async Task TestMyTeams()
        {
            string username = "pa@nextinpact.com";
            string password = "toto12345";

            MatterMostClient client = new MatterMostClient(new Uri("https://gitlab.mattermost.com"),  "dotnetmm", new MatterMostUser(username, password));
            var uat = await client.AuthenticateAsync();
            var teams = await client.GetMyTeamsAsync();
            Assert.True(teams.Any());
        }


        //[Fact]
        //public async Task TestMyTeamsFull()
        //{
        //    string username = "pa@nextinpact.com";
        //    string password = "toto12345";

        //    MatterMostClient client = new MatterMostClient(new Uri("https://gitlab.mattermost.com"),  "dotnetmm", new MatterMostUser(username, password));
        //    var uat = await client.AuthenticateAsync();
        //    var teams = await client.GetFullTeamsAsync();
        //    Assert.NotNull(teams);
           
        //}


        [Fact]
        public async Task TestUnjoinedChannels()
        {
            string username = "pa@nextinpact.com";
            string password = "toto12345";

            MatterMostClient client = new MatterMostClient(new Uri("https://gitlab.mattermost.com"),  "dotnetmm", new MatterMostUser(username, password));
            var uat = await client.AuthenticateAsync();
            var teams = await client.GetMyTeamsAsync();
            var channels = await client.GetUnjoinedChannelsAsync(teams.FirstOrDefault());
            Assert.True(channels.Any());

        }


        [Fact]
        public async Task TestJoinedChannels()
        {
            string username = "pa@nextinpact.com";
            string password = "toto12345";

            MatterMostClient client = new MatterMostClient(new Uri("https://gitlab.mattermost.com"), "dotnetmm", new MatterMostUser(username, password));
            var uat = await client.AuthenticateAsync();
            var teams = await client.GetMyTeamsAsync();
            var channels = await client.GetJoinedChannelAsync(teams.FirstOrDefault());
            Assert.True(channels.Any());

        }
    }
}

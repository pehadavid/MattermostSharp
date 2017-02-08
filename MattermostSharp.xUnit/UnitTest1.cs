using System;
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

            MatterMostClient client = new MatterMostClient(new Uri("https://gitlab.mattermost.com"), "community",
                "dotnetmm", new MatterMostUser(username, password));
            var uat = await client.AuthenticateAsync();
            Assert.True(uat);

        }

        [Fact]
        public async Task TestAuthentNotOk()
        {
            string username = "imjustinvalid@blah.com";
            string password = "toto12345";

            MatterMostClient client = new MatterMostClient(new Uri("https://gitlab.mattermost.com"), "community", "dotnetmm", new MatterMostUser(username, password));
            var uat = await client.AuthenticateAsync();
            Assert.False(uat);
        }
    }
}

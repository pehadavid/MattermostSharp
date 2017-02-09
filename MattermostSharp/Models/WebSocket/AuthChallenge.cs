using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MattermostSharp.Models.WebSocket
{
    public class AuthChallenge
    {
        public class Data
        {

            [JsonProperty("token")]
            public string Token { get; set; }
        }

        [JsonProperty("seq")]
        public int Seq { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public Data AuthData { get; set; }
    }


}

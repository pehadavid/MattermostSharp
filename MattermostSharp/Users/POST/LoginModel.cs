using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MattermostSharp.Users.POST
{
    public class LoginModel
    {
        [JsonProperty(PropertyName = "login_id")]
        public string LoginId { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        [JsonProperty(PropertyName = "device_id")]
        public string DeviceId { get; set; }


    }
}

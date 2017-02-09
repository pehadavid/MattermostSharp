using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MattermostSharp.Models.Teams
{
    /// <summary>
    /// Minimal response for a team request (
    /// </summary>
    public class MiniTeam
    {

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("roles")]
        public string Roles { get; set; }
    }


}

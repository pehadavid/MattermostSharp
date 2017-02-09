using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Newtonsoft.Json;

namespace MattermostSharp.Models.Teams
{
    public class TeamId
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("create_at")]
        public BigInteger CreateAt { get; set; }

        [JsonProperty("update_at")]
        public BigInteger UpdateAt { get; set; }

        [JsonProperty("delete_at")]
        public BigInteger DeleteAt { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("allowed_domains")]
        public string AllowedDomains { get; set; }

        [JsonProperty("invite_id")]
        public string InviteId { get; set; }

        [JsonProperty("allow_open_invite")]
        public bool AllowOpenInvite { get; set; }
    }

    public class FullTeam
    {

        public List<TeamId> Teams;
    }

}

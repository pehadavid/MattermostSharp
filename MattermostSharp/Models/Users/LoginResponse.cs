using System.Numerics;
using Newtonsoft.Json;

namespace MattermostSharp.Models.Users
{
    public class LoginResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("create_at")]
        public BigInteger CreateAt { get; set; }

        [JsonProperty("update_at")]
        public BigInteger UpdateAt { get; set; }

        [JsonProperty("delete_at")]
        public BigInteger DeleteAt { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_verified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("auth_data")]
        public string AuthData { get; set; }

        [JsonProperty("auth_service")]
        public string AuthService { get; set; }

        [JsonProperty("roles")]
        public string Roles { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        //[JsonProperty("notify_props")]
        //public NotifyProps NotifyProps { get; set; }

        //[JsonProperty("props")]
        //public Props Props { get; set; }

        [JsonProperty("last_password_update")]
        public BigInteger LastPasswordUpdate { get; set; }

        [JsonProperty("last_picture_update")]
        public BigInteger LastPictureUpdate { get; set; }

        [JsonProperty("failed_attempts")]
        public int FailedAttempts { get; set; }

        [JsonProperty("mfa_active")]
        public bool MfaActive { get; set; }

        [JsonProperty("mfa_secret")]
        public string MfaSecret { get; set; }
    }
}

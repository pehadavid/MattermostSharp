using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MattermostSharp.Users.POST
{
    public class LoginResponse
    {
        public string id { get; set; }
        public BigInteger create_at { get; set; }
        public BigInteger update_at { get; set; }
        public BigInteger delete_at { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public bool email_verified { get; set; }
        public string password { get; set; }
        public string auth_data { get; set; }
        public string auth_service { get; set; }
        public string roles { get; set; }
        public string locale { get; set; }
        //public NotifyProps notify_props { get; set; }
        //public Props props { get; set; }
        public BigInteger last_password_update { get; set; }
        public BigInteger last_picture_update { get; set; }
        public int failed_attempts { get; set; }
        public bool mfa_active { get; set; }
        public string mfa_secret { get; set; }
    }
}

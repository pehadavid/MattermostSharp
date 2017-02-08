using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace MattermostSharp
{
    public class MatterMostUser
    {

        public string UserName { protected set; get; }
        public string Password { get; protected set; }

        public MatterMostUser(string userName, string password )
        {
            UserName = userName;
            this.Password = password;
        }


        
    }
}

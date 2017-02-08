namespace MattermostSharp.Data
{
    public static class MMEndpoints
    {
        public static class V3
        {
            private static string commonSeg => "api/v3";

            public static class Users
            {

                /// <summary>
                /// POST
                /// </summary>
                public static string Login() => $"{commonSeg}/users/login";

                /// <summary>
                /// GET
                /// </summary>
                public static string Me() => $"{commonSeg}/users/me";

                /// <summary>
                /// POST
                /// </summary>
                public static string Create() => $"{commonSeg}/users/create";

                /// <summary>
                /// POST
                /// </summary>
                public static string Logout() => $"{commonSeg}/users/logout";


                /// <summary>
                /// Get. 
                /// </summary>
                public static string GetUsers(int offset, int limit) => $"{commonSeg}/users/{offset}/{limit}";

                /// <summary>
                /// Get. (users from a team)
                /// </summary>
                public static string GetTeamUsers(int teamId, int offset, int limit) => $"{commonSeg}/teams/{teamId}/users/{offset}/{limit}";


                /// <summary>
                /// POST
                /// </summary>
                public static string SearchUsers() => $"{commonSeg}/users/search";


                /// <summary>
                /// GET
                /// </summary>
                public static string GetSanitizedUserByName(string userName) => $"{commonSeg}/users/name/{userName}";


                /// <summary>
                /// GET
                /// </summary>
                public static string GetSanitizedUserByEmail(string email) => $"{commonSeg}/users/email/{email}";

                /// <summary>
                /// POST
                /// </summary>
                public static string GetSanitizedUserByIds() => $"{commonSeg}/users/ids";


                /// <summary>
                /// get
                /// </summary>
                public static string GetUsersInChannel(int teamId, int channelId, int offset, int limit) => $"{commonSeg}/teams/{teamId}/channels/{channelId}/users/{offset}/{limit}";

                /// <summary>
                /// get
                /// </summary>
                public static string GetUsersNotInChannel(int teamId, int channelId, int offset, int limit) => $"{commonSeg}/teams/{teamId}/channels/{channelId}/users/not_in_channel/{offset}/{limit}";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string UpdateUser() => $"{commonSeg}/users/update";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string UpdateRoles() => $"{commonSeg}/users/update_roles";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string UpdateActive() => $"{commonSeg}/users/update_active";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string UpdateUserNotify() => $"{commonSeg}/users/update_notify";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string UpdateUserPassword() => $"{commonSeg}/users/newpassword";

                /// <summary>
                /// get
                /// </summary>
                /// <returns></returns>
                public static string GetUserAutoComplete() => $"{commonSeg}/users/autocomplete";

                /// <summary>
                /// get
                /// </summary>
                /// <returns></returns>
                public static string GetUserAutoCompleteTeam(int teamId) => $"{commonSeg}/teams/{teamId}/users/autocomplete";

                /// <summary>
                /// get
                /// </summary>
                /// <returns></returns>
                public static string GetUserAutoCompleteTeamChannel(int teamId, int channelId) => $"{commonSeg}/teams/{teamId}/channels/{channelId}/users/autocomplete";

            }

            public static class Websocket
            {
                public static string Main() => "api/v3/users/websocket";
            }

        }


    }
}



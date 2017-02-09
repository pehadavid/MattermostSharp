namespace MattermostSharp.Data
{
    public static class MmEndpoints
    {
        public static class V3
        {
            private static string CommonSeg => "api/v3";

            public static class Users
            {

                /// <summary>
                /// POST
                /// </summary>
                public static string Login() => $"{CommonSeg}/users/login";

                /// <summary>
                /// GET
                /// </summary>
                public static string Me() => $"{CommonSeg}/users/me";

                /// <summary>
                /// POST
                /// </summary>
                public static string Create() => $"{CommonSeg}/users/create";

                /// <summary>
                /// POST
                /// </summary>
                public static string Logout() => $"{CommonSeg}/users/logout";


                /// <summary>
                /// Get. 
                /// </summary>
                public static string GetUsers(int offset, int limit) => $"{CommonSeg}/users/{offset}/{limit}";

                /// <summary>
                /// Get. (users from a team)
                /// </summary>
                public static string GetTeamUsers(string teamId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/users/{offset}/{limit}";


                /// <summary>
                /// POST
                /// </summary>
                public static string SearchUsers() => $"{CommonSeg}/users/search";


                /// <summary>
                /// GET
                /// </summary>
                public static string GetSanitizedUserByName(string userName) => $"{CommonSeg}/users/name/{userName}";


                /// <summary>
                /// GET
                /// </summary>
                public static string GetSanitizedUserByEmail(string email) => $"{CommonSeg}/users/email/{email}";

                /// <summary>
                /// POST
                /// </summary>
                public static string GetSanitizedUserByIds() => $"{CommonSeg}/users/ids";


                /// <summary>
                /// get
                /// </summary>
                public static string GetUsersInChannel(string teamId, string channelId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/users/{offset}/{limit}";

                /// <summary>
                /// get
                /// </summary>
                public static string GetUsersNotInChannel(string teamId, string channelId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/users/not_in_channel/{offset}/{limit}";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string UpdateUser() => $"{CommonSeg}/users/update";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string UpdateRoles() => $"{CommonSeg}/users/update_roles";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string UpdateActive() => $"{CommonSeg}/users/update_active";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string UpdateUserNotify() => $"{CommonSeg}/users/update_notify";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string UpdateUserPassword() => $"{CommonSeg}/users/newpassword";

                /// <summary>
                /// get
                /// </summary>
                /// <returns></returns>
                public static string GetUserAutoComplete() => $"{CommonSeg}/users/autocomplete";

                /// <summary>
                /// get
                /// </summary>
                /// <returns></returns>
                public static string GetUserAutoCompleteTeam(string teamId) => $"{CommonSeg}/teams/{teamId}/users/autocomplete";

                /// <summary>
                /// get
                /// </summary>
                /// <returns></returns>
                public static string GetUserAutoCompleteTeamChannel(string teamId, string channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/users/autocomplete";

            }

            public static class Websocket
            {
                public static string Main() => "api/v3/users/websocket";
            }

            public static class Teams
            {
                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string Create() => $"{CommonSeg}/teams/create";

                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetAll() => $"{CommonSeg}/teams/all";

                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetUserTeams() => $"{CommonSeg}/teams/members";


                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string Getunread() => $"{CommonSeg}/teams/unread";


                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetTeamMembers(string teamId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/members/{offset}/{limit}";

                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetSingleTeamMember(string teamId, string userId) => $"{CommonSeg}/teams/{teamId}/members/{userId}";

                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetTeamMembersByIds(string teamId) => $"{CommonSeg}/teams/{teamId}/members/ids";


                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetTeamObjectById(string teamId) => $"{CommonSeg}/teams/{teamId}/me";


                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetTeamObjectByName(string teamName) => $"{CommonSeg}/teams/name/{teamName}";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string Update(string teamId) => $"{CommonSeg}/teams/{teamId}/update";

                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetStats(string teamId) => $"{CommonSeg}/teams/{teamId}/stats";


                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string AddUserToTeam(string teamId) => $"{CommonSeg}/teams/{teamId}/add_user_to_team";



                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string RemoveUserFromTeam(string teamId) => $"{CommonSeg}/teams/{teamId}/remove_user_from_team";


                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetListSlashCommands(string teamId) => $"{CommonSeg}/teams/{teamId}/commands/list_team_commands";


            }

            public static class Channels
            {
                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string Create(string teamId) => $"{CommonSeg}/teams/{teamId}/channels/create";


                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string Update(string teamId) => $"{CommonSeg}/teams/{teamId}/channels/update";

                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string View(string teamId) => $"{CommonSeg}/teams/{teamId}/channels/view";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string GetChannelsForUser(string teamId) => $"{CommonSeg}/teams/{teamId}/channels/";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string GetChannelByName(string teamId) => $"{CommonSeg}/teams/{teamId}/channels/name";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string GetUnjoinedChannel(string teamId, int offset = 0, int limit = 0) => (offset < 1 || limit < 1) ? $"{CommonSeg}/teams/{teamId}/channels/more" : $"{CommonSeg}/teams/{teamId}/channels/more/{offset}/{limit}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string GetChannelById(string teamId, string channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string GetChannelStats(string teamId, string channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/stats";

                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string Delete(string teamId, string channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/delete";


                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string AddUser(string teamId, string channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/add";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string GetMember(string teamId, string channelId, string userId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/members/{userId}";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string GetMembersById(string teamId, string channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/members/ids";



                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string UpdateMemberRoles(string teamId, string channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/update_member_roles";


                /// <summary>
                /// get
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string Autocomplete(string teamId) => $"{CommonSeg}/teams/{teamId}/channels/autocomplete";


                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string MoreSearch(string teamId) => $"{CommonSeg}/teams/{teamId}/channels/more/searchs";

            }

            public static class Posts
            {
                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string Search(string teamId) => $"{CommonSeg}/teams/{teamId}/posts/search";
                
                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetFlagged(string teamId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/flagged/{offset}/{limit}";


                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string Create(string teamId, string channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/posts/create";


                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string Update(string teamId, string channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/posts/update";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string Get(string teamId, string channelId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/posts/page/{offset}/{limit}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetSince(string teamId, string channelId,string unixTime) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/posts/since/{unixTime}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetPost(string teamId, string channelId, string postId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/posts/{postId}/get";

                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <param name="postId"></param>
                /// <returns></returns>
                public static string Delete(string teamId, string channelId, string postId) => $"{CommonSeg}/teams/{teamId}/channels/channels/{channelId}/posts/{postId}/delete";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetPostsBefore(string teamId, string channelId, string postId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/channels/{channelId}/posts/{postId}/before/{offset}/{limit}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetPostsAfter(string teamId, string channelId, string postId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/channels/{channelId}/posts/{postId}/after/{offset}/{limit}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetPostReactions(string teamId, string channelId, string postId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/channels/{channelId}/posts/{postId}/reactions";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string ReactPost(string teamId, string channelId, string postId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/channels/{channelId}/posts/{postId}/reactions/save";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string RemoveReaction(string teamId, string channelId, string postId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/channels/{channelId}/posts/{postId}/reactions/delete";

            }

        }


    }
}



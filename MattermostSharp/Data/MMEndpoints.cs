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
                public static string GetTeamUsers(int teamId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/users/{offset}/{limit}";


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
                public static string GetUsersInChannel(int teamId, int channelId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/users/{offset}/{limit}";

                /// <summary>
                /// get
                /// </summary>
                public static string GetUsersNotInChannel(int teamId, int channelId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/users/not_in_channel/{offset}/{limit}";

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
                public static string GetUserAutoCompleteTeam(int teamId) => $"{CommonSeg}/teams/{teamId}/users/autocomplete";

                /// <summary>
                /// get
                /// </summary>
                /// <returns></returns>
                public static string GetUserAutoCompleteTeamChannel(int teamId, int channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/users/autocomplete";

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
                public static string GetMembers() => $"{CommonSeg}/teams/members";


                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string Getunread() => $"{CommonSeg}/teams/unread";


                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetTeamMembers(int teamId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/members/{offset}/{limit}";

                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetSingleTeamMember(int teamId, int userId) => $"{CommonSeg}/teams/{teamId}/members/{userId}";

                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetTeamMembersByIds(int teamId) => $"{CommonSeg}/teams/{teamId}/members/ids";


                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetTeamObject(int teamId) => $"{CommonSeg}/teams/{teamId}/me";


                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetTeamObject(string teamName) => $"{CommonSeg}/teams/name/{teamName}";

                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string Update(int teamId) => $"{CommonSeg}/teams/{teamId}/update";

                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetStats(int teamId) => $"{CommonSeg}/teams/{teamId}/stats";


                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string AddUserToTeam(int teamId) => $"{CommonSeg}/teams/{teamId}/add_user_to_team";



                /// <summary>
                /// POST
                /// </summary>
                /// <returns></returns>
                public static string RemoveUserFromTeam(int teamId) => $"{CommonSeg}/teams/{teamId}/remove_user_from_team";


                /// <summary>
                /// GET
                /// </summary>
                /// <returns></returns>
                public static string GetListSlashCommands(int teamId) => $"{CommonSeg}/teams/{teamId}/commands/list_team_commands";


            }

            public static class Channels
            {
                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string Create(int teamId) => $"{CommonSeg}/teams/{teamId}/channels/create";


                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string Update(int teamId) => $"{CommonSeg}/teams/{teamId}/channels/update";

                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string View(int teamId) => $"{CommonSeg}/teams/{teamId}/channels/view";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string GetChannelsForUsers(int teamId) => $"{CommonSeg}/teams/{teamId}/channels";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string GetChannelByName(int teamId) => $"{CommonSeg}/teams/{teamId}/channels/name";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string GetUnjoinedChannel(int teamId, int offset = 0, int limit = 0) => (offset < 1 || limit < 1) ? $"{CommonSeg}/teams/{teamId}/channels/more" : $"{CommonSeg}/teams/{teamId}/channels/more/{offset}/{limit}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string GetChannelById(int teamId, int channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string GetChannelStats(int teamId, int channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/stats";

                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string Delete(int teamId, int channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/delete";


                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <returns></returns>
                public static string AddUser(int teamId, int channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/add";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string GetMember(int teamId, int channelId, int userId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/members/{userId}";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string GetMembersById(int teamId, int channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/members/ids";



                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string UpdateMemberRoles(int teamId, int channelId) => $"{CommonSeg}/teams/{teamId}/channels/{channelId}/update_member_roles";


                /// <summary>
                /// get
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string Autocomplete(int teamId) => $"{CommonSeg}/teams/{teamId}/channels/autocomplete";


                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string MoreSearch(int teamId) => $"{CommonSeg}/teams/{teamId}/channels/more/searchs";

            }

            public static class Posts
            {
                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channelId"></param>
                /// <returns></returns>
                public static string Search(int teamId) => $"{CommonSeg}/teams/{teamId}/posts/search";
                
                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetFlagged(int teamId, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/flagged/{offset}/{limit}";


                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <param name="channel_id"></param>
                /// <returns></returns>
                public static string Create(int teamId, int channel_id) => $"{CommonSeg}/teams/{teamId}/channels/{channel_id}/posts/create";


                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <param name="channel_id"></param>
                /// <returns></returns>
                public static string Update(int teamId, int channel_id) => $"{CommonSeg}/teams/{teamId}/channels/{channel_id}/posts/update";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channel_id"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string Get(int teamId, int channel_id, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/channels/{channel_id}/posts/page/{offset}/{limit}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channel_id"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetSince(int teamId, int channel_id,int unixTime) => $"{CommonSeg}/teams/{teamId}/channels/{channel_id}/posts/since/{unixTime}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channel_id"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetPost(int teamId, int channel_id, int post_id) => $"{CommonSeg}/teams/{teamId}/channels/{channel_id}/posts/{post_id}/get";

                /// <summary>
                /// POST
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channel_id"></param>
                /// <param name="post_id"></param>
                /// <returns></returns>
                public static string Delete(int teamId, int channel_id, int post_id) => $"{CommonSeg}/teams/{teamId}/channels/channels/{channel_id}/posts/{post_id}/delete";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channel_id"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetPostsBefore(int teamId, int channel_id, int post_id, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/channels/{channel_id}/channels/{channel_id}/posts/{post_id}/before/{offset}/{limit}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channel_id"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetPostsAfter(int teamId, int channel_id, int post_id, int offset, int limit) => $"{CommonSeg}/teams/{teamId}/channels/{channel_id}/channels/{channel_id}/posts/{post_id}/after/{offset}/{limit}";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channel_id"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string GetPostReactions(int teamId, int channel_id, int post_id) => $"{CommonSeg}/teams/{teamId}/channels/{channel_id}/channels/{channel_id}/posts/{post_id}/reactions";

                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channel_id"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string ReactPost(int teamId, int channel_id, int post_id) => $"{CommonSeg}/teams/{teamId}/channels/{channel_id}/channels/{channel_id}/posts/{post_id}/reactions/save";


                /// <summary>
                /// GET
                /// </summary>
                /// <param name="teamId"></param>
                /// <param name="channel_id"></param>
                /// <param name="offset"></param>
                /// <param name="limit"></param>
                /// <returns></returns>
                public static string RemoveReaction(int teamId, int channel_id, int post_id) => $"{CommonSeg}/teams/{teamId}/channels/{channel_id}/channels/{channel_id}/posts/{post_id}/reactions/delete";

            }

        }


    }
}



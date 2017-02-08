using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace MattermostSharp
{
    public static class RestSharpExt
    {

        public static  Task<IRestResponse> ExecuteTaskAsync(this RestClient client, IRestRequest request)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();

            client.ExecuteAsync(request, response =>
            {
                tcs.SetResult(response);
                    
               
            });

            return tcs.Task;
        }


        public static void AddJsonNetBody(this IRestRequest request, object body)
        {
            var strBody = JsonConvert.SerializeObject(body);
            request.AddParameter("application/json", strBody, ParameterType.RequestBody);
    
        }
    }

}

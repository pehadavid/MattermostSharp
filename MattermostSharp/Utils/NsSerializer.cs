using System.IO;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace MattermostSharp.Utils
{
    public class NewtonsoftJsonSerializer : RestSharp.Serializers.ISerializer, RestSharp.Deserializers.IDeserializer
    {
      
        public string ContentType
        {
            get { return "application/json"; } // Probably used for Serialization?
            set { }
        }

        public string DateFormat { get; set; }

        public string Namespace { get; set; }

        public string RootElement { get; set; }
 

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public T Deserialize<T>(RestSharp.IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public static NewtonsoftJsonSerializer Default => new NewtonsoftJsonSerializer();

       
    }

}
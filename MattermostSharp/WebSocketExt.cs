using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MattermostSharp
{
    public static class WebSocketExt
    {
        public static Task SendAsync<T>(this ClientWebSocket webSocket, T item, CancellationToken token)
        {
            var data = JsonConvert.SerializeObject(item);
            var btes = Encoding.UTF8.GetBytes(data);
            ArraySegment<byte> buffer = new ArraySegment<byte>(btes);
            return webSocket.SendAsync(buffer, WebSocketMessageType.Text, true,  token);
        }
    }
}

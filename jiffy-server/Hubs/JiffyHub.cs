using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace jiffy_server.Hubs
{
    public class JiffyHub : Hub
    {
        public async Task GetUsernameRequest()
        {
            await Clients.Caller.SendAsync("getUsernameResponse", Context.ConnectionId);
        }

        public async Task StartChatRequest(string friendUsername)
        {
            await Clients.Client(friendUsername).SendAsync("startChatRequest", Context.ConnectionId);
        }
        
        public async Task AcceptChatRequest(string friendUsername)
        {
            await Clients.Client(friendUsername).SendAsync("startChatAccepted");
        }
    }
}
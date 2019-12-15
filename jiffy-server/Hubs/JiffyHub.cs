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
            if (Context.ConnectionId == friendUsername)
            {
                return;
            }
            
            await Clients.Client(friendUsername).SendAsync("startChatRequest", Context.ConnectionId);
        }
        
        public async Task AcceptChatRequest(string friendUsername)
        {
            await Clients.Client(friendUsername).SendAsync("startChatAccepted");
        }

        public async Task IceCandidate(string friendUsername, string candidate)
        {
            await Clients.Client(friendUsername).SendAsync("iceCandidate", candidate);
        }

        public async Task Sdp(string friendUsername, string description)
        {
            await Clients.Client(friendUsername).SendAsync("sdp", description);
        }
    }
}
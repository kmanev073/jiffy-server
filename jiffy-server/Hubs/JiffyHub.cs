using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace jiffy_server.Hubs
{
    public class JiffyHub : Hub
    {
        public async Task GetUsername()
        {
            await Clients.Caller.SendAsync("getUsername", Context.ConnectionId);
        }
    }
}
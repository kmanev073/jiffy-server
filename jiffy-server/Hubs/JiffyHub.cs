using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace jiffy_server.Hubs
{
    public class JiffyHub : Hub
    {
        public async Task StartChat(string senderId, string receiverId)
        {
            Console.WriteLine($"Sender Id: {senderId}, Receiver Id: {receiverId}");
            //await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
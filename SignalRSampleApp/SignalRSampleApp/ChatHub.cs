using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRSampleApp
{
    public class ChatHub : Hub
    {
        
        public Task Send(string data)
        {
            return Clients.All.SendAsync("Send", data);
        }
    }

}

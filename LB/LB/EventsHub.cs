using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace LB
{
    public class EventsHub : Hub
    {
        public void Send(string name, string message)
        {          
            Clients.All.broadcastMessage(name, message);
        }
    }
}
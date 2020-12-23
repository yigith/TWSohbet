using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TWSohbet
{
    public class ChatHub : Hub
    {
        // client'lardan gelen mesajı karşılar
        public void SendMessage(string username, string message)
        {
            Clients.All.newMessage(username, message);
        }
    }
}
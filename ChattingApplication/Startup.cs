using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChattingApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            app.MapSignalR();
        }
    }

    public class ChatHub : Microsoft.AspNet.SignalR.Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}
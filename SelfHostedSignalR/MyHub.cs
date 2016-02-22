using System;
using System.Threading;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SelfHostedSignalR
{
    [HubName("myHub")]
    public class MyHub : Hub
    {
        public MyHub(IHubDependency hubDepedency)
        {            
            hubDepedency.PrintMessage();
        }

        public void StartSendingMessage()
        {
            while (true)
            {

                Thread.Sleep(1000);
                Clients.All.newData($"new data on server time: {DateTime.Now}");
            }
        }

        public void SendMessageToAllClient()
        {
            Clients.All.sendMessage("Hey!");
        }
    }    
}

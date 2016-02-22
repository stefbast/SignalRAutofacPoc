using Microsoft.AspNet.SignalR;

namespace SelfHostedSignalR
{
    public class MyDependency : IMyDependency
    {
        public void SendStuffToClient()
        {
            GlobalHost.ConnectionManager.GetHubContext<MyHub>().Clients.All.newMessageFromMyDependency("this comes from MyDependency");}
    }
}
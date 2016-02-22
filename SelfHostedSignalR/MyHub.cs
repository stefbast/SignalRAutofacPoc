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
    }    
}

using System.Diagnostics;

namespace SelfHostedSignalR
{
    public class HubDependency : IHubDependency
    {
        public void PrintMessage()
        {
            Debug.WriteLine("Message");
        }
    }
}

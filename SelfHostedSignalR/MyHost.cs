namespace SelfHostedSignalR
{
    public class MyHost : IMyHost
    {
        private readonly IMyDependency _myDependency;

        public MyHost(IMyDependency myDependency)
        {
            _myDependency = myDependency;
        }

        public void ActionThatShouldSendToClients()
        {
            _myDependency.SendStuffToClient();
        }
    }
}
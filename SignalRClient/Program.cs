using System;
using Microsoft.AspNet.SignalR.Client;

namespace SignalRClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var hubConnection = new HubConnection("http://localhost:6789/signalr/myHub");
            var myHubProxy = hubConnection.CreateHubProxy("myHub");           
            myHubProxy.On<string>("newMessageFromMyDependency", data => Console.WriteLine("Message server dependency: {0}", data));
            hubConnection.Start().Wait();            
            Console.ReadLine();
        }
    }
}

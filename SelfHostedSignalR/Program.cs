using System;
using System.Reflection;
using Autofac;
using Autofac.Integration.SignalR;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;

namespace SelfHostedSignalR
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<MyDependency>().As<IMyDependency>();
            containerBuilder.RegisterType<MyHost>().As<IMyHost>();
            containerBuilder.RegisterType<HubDependency>().As<IHubDependency>();
            containerBuilder.RegisterHubs(Assembly.GetExecutingAssembly());
            var container = containerBuilder.Build();            
            GlobalHost.DependencyResolver = new AutofacDependencyResolver(container);

            using (WebApp.Start<Startup>("http://localhost:6789"))
            {
                Console.WriteLine("Hubs running...");
                var myHost = container.Resolve<IMyHost>();
                Console.WriteLine("Send data to clients");
                while (Console.ReadLine() != "stop")
                {
                    myHost.ActionThatShouldSendToClients();
                }                                
            }
            
        }
    }
}


using Microsoft.AspNet.SignalR;
using Owin;

namespace SelfHostedSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(new HubConfiguration());
        }
    }
}
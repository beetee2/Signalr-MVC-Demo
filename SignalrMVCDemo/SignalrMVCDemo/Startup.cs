using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalrMVCDemo.Startup))]
namespace SignalrMVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}

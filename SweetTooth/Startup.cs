using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SweetTooth.Startup))]
namespace SweetTooth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

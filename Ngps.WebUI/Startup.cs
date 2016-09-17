using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ngps.WebUI.Startup))]
namespace Ngps.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

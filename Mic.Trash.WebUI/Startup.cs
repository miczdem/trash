using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mic.Trash.WebUI.Startup))]
namespace Mic.Trash.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            IoC.RegisterContainer(app);
            ConfigureAuth(app);
        }
    }
}

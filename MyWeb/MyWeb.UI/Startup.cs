using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWeb.UI.Startup))]
namespace MyWeb.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

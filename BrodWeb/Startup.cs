using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrodWeb.Startup))]
namespace BrodWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

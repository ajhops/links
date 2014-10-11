using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Links.Web.Startup))]
namespace Links.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

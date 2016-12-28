using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ultra.Webshop.Web.Startup))]
namespace Ultra.Webshop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

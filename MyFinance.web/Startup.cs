using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFinance.web.Startup))]
namespace MyFinance.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

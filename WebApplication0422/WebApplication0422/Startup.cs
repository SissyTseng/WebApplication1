using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication0422.Startup))]
namespace WebApplication0422
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

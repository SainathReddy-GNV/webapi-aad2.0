using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(webapi_oauth2.Startup))]
namespace webapi_oauth2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

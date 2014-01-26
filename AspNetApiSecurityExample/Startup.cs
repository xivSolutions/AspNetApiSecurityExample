using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetApiSecurityExample.Startup))]
namespace AspNetApiSecurityExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

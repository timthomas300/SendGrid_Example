using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SendGrid_Example.Startup))]
namespace SendGrid_Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

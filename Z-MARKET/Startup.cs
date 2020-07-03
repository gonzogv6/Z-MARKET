using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Z_MARKET.Startup))]
namespace Z_MARKET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

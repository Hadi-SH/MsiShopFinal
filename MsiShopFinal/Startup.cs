using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MsiShopFinal.Startup))]
namespace MsiShopFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

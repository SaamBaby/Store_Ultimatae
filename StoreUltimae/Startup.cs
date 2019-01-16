using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreUltimae.Startup))]
namespace StoreUltimae
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

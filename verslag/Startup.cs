using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(verslag.Startup))]
namespace verslag
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChocolateSystem.Startup))]
namespace ChocolateSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

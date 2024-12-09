using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppWebAlmacenCentral.Startup))]
namespace AppWebAlmacenCentral
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

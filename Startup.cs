using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular2_.Net_WebForms.Startup))]
namespace Angular2_.Net_WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

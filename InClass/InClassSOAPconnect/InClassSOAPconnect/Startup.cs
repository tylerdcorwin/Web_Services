using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClassSOAPconnect.Startup))]
namespace InClassSOAPconnect
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

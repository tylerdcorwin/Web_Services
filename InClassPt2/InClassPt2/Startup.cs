using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClassPt2.Startup))]
namespace InClassPt2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

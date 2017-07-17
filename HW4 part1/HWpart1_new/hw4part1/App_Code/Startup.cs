using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hw4part1.Startup))]
namespace hw4part1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

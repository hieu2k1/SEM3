using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingtipToys0.Startup))]
namespace WingtipToys0
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

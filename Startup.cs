using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shopping_Cart.Startup))]
namespace Shopping_Cart
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

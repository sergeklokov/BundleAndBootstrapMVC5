using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BundleAndBootstrapMVC5.Startup))]
namespace BundleAndBootstrapMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

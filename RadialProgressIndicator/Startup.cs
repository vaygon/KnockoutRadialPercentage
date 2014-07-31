using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RadialProgressIndicator.Startup))]
namespace RadialProgressIndicator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

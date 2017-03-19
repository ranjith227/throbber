using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThrobAndWater.Startup))]
namespace ThrobAndWater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

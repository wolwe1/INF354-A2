using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(u17112631_A2.Startup))]
namespace u17112631_A2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

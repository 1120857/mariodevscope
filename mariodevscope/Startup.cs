using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mariodevscope.Startup))]
namespace mariodevscope
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

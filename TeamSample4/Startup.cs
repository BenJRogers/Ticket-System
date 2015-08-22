using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamSample4.Startup))]
namespace TeamSample4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

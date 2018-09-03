using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstudosGit.Startup))]
namespace EstudosGit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git.Help.Startup))]
namespace Git.Help
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

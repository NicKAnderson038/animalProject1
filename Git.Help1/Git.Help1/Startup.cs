using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git.Help1.Startup))]
namespace Git.Help1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

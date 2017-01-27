using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(animalProject1.Startup))]
namespace animalProject1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

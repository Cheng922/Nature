using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nature.Startup))]
namespace Nature
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

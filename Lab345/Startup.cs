using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab345.Startup))]
namespace Lab345
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

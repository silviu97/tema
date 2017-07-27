using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviezApp.Startup))]
namespace MoviezApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

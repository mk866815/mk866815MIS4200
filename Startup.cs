using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mk866815MIS4200.Startup))]
namespace mk866815MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDP_Manager.Startup))]
namespace CDP_Manager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

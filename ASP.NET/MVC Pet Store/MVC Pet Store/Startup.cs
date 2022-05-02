using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Pet_Store.Startup))]
namespace MVC_Pet_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

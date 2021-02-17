using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppDeve.Startup))]
namespace AppDeve
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

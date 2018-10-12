using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAnuv.Startup))]
namespace WebAnuv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

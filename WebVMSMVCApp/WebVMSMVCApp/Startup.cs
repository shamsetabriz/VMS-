using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebVMSMVCApp.Startup))]
namespace WebVMSMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

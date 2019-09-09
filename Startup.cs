using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OSullivan_MIS4800_SD1.Startup))]
namespace OSullivan_MIS4800_SD1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

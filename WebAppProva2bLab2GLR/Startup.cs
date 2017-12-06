using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProva2bLab2GLR.Startup))]
namespace WebAppProva2bLab2GLR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

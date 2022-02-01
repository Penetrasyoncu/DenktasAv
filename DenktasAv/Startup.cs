using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DenktasAv.Startup))]
namespace DenktasAv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

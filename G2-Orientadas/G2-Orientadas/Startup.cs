using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(G2_Orientadas.Startup))]
namespace G2_Orientadas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

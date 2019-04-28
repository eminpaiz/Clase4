using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ejemplo_Clase4.web.Startup))]
namespace Ejemplo_Clase4.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

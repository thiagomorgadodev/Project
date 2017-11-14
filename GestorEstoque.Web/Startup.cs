using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestorEstoque.Web.Startup))]
namespace GestorEstoque.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

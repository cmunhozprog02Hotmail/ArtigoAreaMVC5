using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArtigoAreaMVC5.Startup))]
namespace ArtigoAreaMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

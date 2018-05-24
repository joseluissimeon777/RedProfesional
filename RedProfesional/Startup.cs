using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedProfesional.Startup))]
namespace RedProfesional
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

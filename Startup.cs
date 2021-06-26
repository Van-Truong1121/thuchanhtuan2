using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Laptrinhwedtuan2.Startup))]
namespace Laptrinhwedtuan2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

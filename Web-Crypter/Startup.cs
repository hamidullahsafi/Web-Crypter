using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Crypter.Startup))]
namespace Web_Crypter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Briangrandcircus1.Startup))]
namespace Briangrandcircus1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

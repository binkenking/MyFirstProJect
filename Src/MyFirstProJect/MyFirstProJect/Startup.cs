using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstProJect.Startup))]
namespace MyFirstProJect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

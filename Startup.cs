using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Library_management_System.Startup))]
namespace Library_management_System
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

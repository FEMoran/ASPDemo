using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOpsDemo.Startup))]
namespace DevOpsDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

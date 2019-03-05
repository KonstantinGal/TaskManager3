using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskManager3.Startup))]
namespace TaskManager3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

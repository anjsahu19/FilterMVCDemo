using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FiltersDemo.Startup))]
namespace FiltersDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

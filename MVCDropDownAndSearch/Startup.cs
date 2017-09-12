using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDropDownAndSearch.Startup))]
namespace MVCDropDownAndSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

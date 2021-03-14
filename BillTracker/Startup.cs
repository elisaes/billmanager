using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillTracker.Startup))]
namespace BillTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

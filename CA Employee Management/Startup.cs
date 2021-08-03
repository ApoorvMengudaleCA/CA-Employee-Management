using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CA_Employee_Management.Startup))]
namespace CA_Employee_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

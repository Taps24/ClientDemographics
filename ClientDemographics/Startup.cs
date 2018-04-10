using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientDemographics.Startup))]
namespace ClientDemographics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

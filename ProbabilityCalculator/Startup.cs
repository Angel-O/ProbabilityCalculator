using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProbabilityCalculator.Startup))]
namespace ProbabilityCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

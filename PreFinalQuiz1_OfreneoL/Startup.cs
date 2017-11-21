using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreFinalQuiz1_OfreneoL.Startup))]
namespace PreFinalQuiz1_OfreneoL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

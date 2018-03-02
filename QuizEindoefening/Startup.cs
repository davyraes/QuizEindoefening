using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizEindoefening.Startup))]
namespace QuizEindoefening
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

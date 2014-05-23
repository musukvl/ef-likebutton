using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LikeCounter.Startup))]
namespace LikeCounter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {           
        }
    }
}

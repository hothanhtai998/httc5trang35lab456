using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoThanhTai_baiLab456.Startup))]
namespace HoThanhTai_baiLab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

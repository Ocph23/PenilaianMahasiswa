using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppPenilaianMahasiswa.Startup))]
namespace AppPenilaianMahasiswa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Logga;
using Logga.Entities;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoggaSample.Mvc.Startup))]
namespace LoggaSample.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            var options = new LoggaOptions
            {
                ConnectionString = "DefaultConnection",
                CreateSchema = false
            };

            LoggaConfiguration.UseSqlServerData(options);
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestCompany.TestProject.Configuration;

namespace TestCompany.TestProject.Web.Host.Startup
{
    [DependsOn(
       typeof(TestProjectWebCoreModule))]
    public class TestProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestProjectWebHostModule).GetAssembly());
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TestCompany.TestProject.Configuration;
using TestCompany.TestProject.Web;

namespace TestCompany.TestProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TestProjectDbContextFactory : IDesignTimeDbContextFactory<TestProjectDbContext>
    {
        public TestProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TestProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TestProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TestProjectConsts.ConnectionStringName));

            return new TestProjectDbContext(builder.Options);
        }
    }
}

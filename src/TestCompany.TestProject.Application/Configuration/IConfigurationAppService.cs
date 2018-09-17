using System.Threading.Tasks;
using TestCompany.TestProject.Configuration.Dto;

namespace TestCompany.TestProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

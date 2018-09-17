using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestCompany.TestProject.Configuration.Dto;

namespace TestCompany.TestProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

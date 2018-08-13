using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyDemoAbp.Configuration.Dto;

namespace MyDemoAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyDemoAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

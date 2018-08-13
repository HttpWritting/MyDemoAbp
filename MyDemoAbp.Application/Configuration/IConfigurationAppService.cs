using System.Threading.Tasks;
using Abp.Application.Services;
using MyDemoAbp.Configuration.Dto;

namespace MyDemoAbp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
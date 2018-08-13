using System.Threading.Tasks;
using Abp.Application.Services;
using MyDemoAbp.Authorization.Accounts.Dto;

namespace MyDemoAbp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

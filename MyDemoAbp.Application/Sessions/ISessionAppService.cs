using System.Threading.Tasks;
using Abp.Application.Services;
using MyDemoAbp.Sessions.Dto;

namespace MyDemoAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyDemoAbp.MultiTenancy.Dto;

namespace MyDemoAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

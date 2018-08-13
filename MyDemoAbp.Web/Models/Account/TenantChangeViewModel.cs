using Abp.AutoMapper;
using MyDemoAbp.Sessions.Dto;

namespace MyDemoAbp.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
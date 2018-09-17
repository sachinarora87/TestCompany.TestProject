using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TestCompany.TestProject.MultiTenancy.Dto;

namespace TestCompany.TestProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

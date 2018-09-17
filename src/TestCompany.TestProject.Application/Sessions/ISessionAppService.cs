using System.Threading.Tasks;
using Abp.Application.Services;
using TestCompany.TestProject.Sessions.Dto;

namespace TestCompany.TestProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

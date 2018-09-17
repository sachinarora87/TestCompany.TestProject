using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TestCompany.TestProject.Roles.Dto;
using TestCompany.TestProject.Users.Dto;

namespace TestCompany.TestProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

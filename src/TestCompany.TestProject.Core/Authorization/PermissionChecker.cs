using Abp.Authorization;
using TestCompany.TestProject.Authorization.Roles;
using TestCompany.TestProject.Authorization.Users;

namespace TestCompany.TestProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

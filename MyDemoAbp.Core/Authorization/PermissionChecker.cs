using Abp.Authorization;
using MyDemoAbp.Authorization.Roles;
using MyDemoAbp.Authorization.Users;

namespace MyDemoAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

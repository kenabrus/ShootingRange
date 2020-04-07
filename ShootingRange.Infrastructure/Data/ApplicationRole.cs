using Microsoft.AspNetCore.Identity;

namespace ShootingRange.Infrastructure.Data
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base(){}
        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }
}
using KufarManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Policy;

namespace KufarManagementSystem.Utilities.UserRoles
{
    public static class UserRightsCreator
    {
        public static void SeedData(RoleManager<IdentityRole> roleManager)
        {
            if (roleManager == null)
                throw new ArgumentNullException();

            SeedRoles(roleManager);
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            foreach (String roleName in Enum.GetNames(typeof(ApplicatiinUserRoles)))
            {
                AddRole(roleManager, roleName);
            }
        }

        private static void AddRole(RoleManager<IdentityRole> roleManager, String roleName)
        {
            if (!roleManager.RoleExistsAsync(roleName).Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = roleName;
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }
    }
}

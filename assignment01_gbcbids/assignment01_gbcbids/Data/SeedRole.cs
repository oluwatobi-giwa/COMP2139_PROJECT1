using Microsoft.AspNetCore.Identity;
using System;

namespace assignment01_gbcbids.Data
{
    public static class SeedRole
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            //Seed Roles
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole("seller"));
            await roleManager.CreateAsync(new IdentityRole("buyer"));

            
            /*var userInDb = await userManager.FindByEmailAsync(user.Email);
            if (userInDb == null)
            {
                await userManager.CreateAsync(user, "Admin@123");
                await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
            }*/
        }
    }
}

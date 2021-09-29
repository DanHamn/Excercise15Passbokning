using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Övning15Passbokning.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning15Passbokning.Data.Data
{

    public class SeedData
    {
        private static RoleManager<IdentityRole> roleManager;
        private static UserManager<ApplicationUser> userManager;

        public static async Task InitAsync(ApplicationDbContext _context, IServiceProvider services)
        {
            if (_context is null) throw new NullReferenceException(nameof(ApplicationDbContext));

            roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            if (roleManager is null) throw new NullReferenceException(nameof(RoleManager<IdentityRole>));

            userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            if (userManager is null) throw new NullReferenceException(nameof(UserManager<ApplicationUser>));

            var role = new IdentityRole { Name = "Admin" };

            await roleManager.CreateAsync(role);

            var adminEmail = "admin@gym.se";

            if (await userManager.FindByEmailAsync(adminEmail) is null)
            {
                var admin = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true,
                    FirstName="Ad",
                    LastName="Min"
                    
                };

                await userManager.CreateAsync(admin, "Abc123!");

                await userManager.AddToRoleAsync(admin, "Admin");
            }

            await _context.SaveChangesAsync();
        }
    }
}

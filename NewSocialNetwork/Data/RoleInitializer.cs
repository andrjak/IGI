using Microsoft.AspNetCore.Identity;
using NewSocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSocialNetwork.Data
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "79821843rt@gmail.com";
            string password = "$aN21111112Na$";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User
                {
                    Email = adminEmail,
                    UserName = adminEmail,
                    Birthday = new DateTime(2000, 4, 21),
                    Country = "Belarus",
                    Name = "Andrey",
                    Surname = "Valetko",
                };
                User friend = new User
                {
                    Email = "79821842rt@gmail.com",
                    UserName = "79821842rt@gmail.com",
                    Birthday = new DateTime(2000, 1, 19),
                    Country = "Belarus",
                    Name = "Alexander",
                    Surname = "Matyushonak",
                };

                IdentityResult result1 = await userManager.CreateAsync(admin, password);
                IdentityResult result2 = await userManager.CreateAsync(friend, password);
                if (result1.Succeeded && result2.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                    await userManager.AddToRoleAsync(friend, "user");
                }
            }
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using MiniShopApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, ICardService cardService, IConfiguration configuration)
        {
            var roles = configuration.GetSection("UserData:Roles").GetChildren().Select(r => r.Value).ToArray();
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            var users = configuration.GetSection("UserData:Users");
            foreach (var section in users.GetChildren())
            {
                var userName = section.GetValue<string>("UserName");
                var password = section.GetValue<string>("Password");
                var email = section.GetValue<string>("Email");
                var role = section.GetValue<string>("Role");
                var firstName = section.GetValue<string>("FirstName");
                var lastName = section.GetValue<string>("LastName");
                if (await userManager.FindByNameAsync(userName)==null)
                {
                    var user = new User()
                    {
                        UserName=userName,
                        Email=email,
                        FirstName=firstName,
                        LastName=lastName,
                        EmailConfirmed=true,
                    };
                    var result = await userManager.CreateAsync(user, password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, role);
                        cardService.InitializeCard(user.Id);
                    }
                }
            }

            ////Admin oluşturma kodları
            //var adminUserName = configuration["UserData:AdminUser:UserName"];
            //var adminEmail = configuration["UserData:AdminUser:Email"];
            //var adminPassword = configuration["UserData:AdminUser:Password"];
            //var adminRole = configuration["UserData:AdminUser:Role"];
            //if (await userManager.FindByNameAsync(adminUserName)==null)
            //{
            //    await roleManager.CreateAsync(new IdentityRole(adminRole));
            //    var adminUser = new User()
            //    {
            //        UserName = adminUserName,
            //        Email = adminEmail,
            //        FirstName = "Admin",
            //        LastName = "Admin",
            //        EmailConfirmed = true
            //    };
            //    var result = await userManager.CreateAsync(adminUser, adminPassword);
            //    if (result.Succeeded)
            //    {
            //        await userManager.AddToRoleAsync(adminUser, adminRole);
            //    }
            //}

            ////User oluşturma kodları
            //var userUserName = configuration["UserData:CustomerUser:UserName"];
            //var userEmail = configuration["UserData:CustomerUser:Email"];
            //var userPassword = configuration["UserData:CustomerUser:Password"];
            //var userRole = configuration["UserData:CustomerUser:Role"];
            //if (await userManager.FindByNameAsync(userUserName) == null)
            //{
            //    await roleManager.CreateAsync(new IdentityRole(userRole));
            //    var userUser = new User()
            //    {
            //        UserName = userUserName,
            //        Email = userEmail,
            //        FirstName = "User",
            //        LastName = "User",
            //        EmailConfirmed = true
            //    };
            //    var result = await userManager.CreateAsync(userUser, userPassword);
            //    if (result.Succeeded)
            //    {
            //        await userManager.AddToRoleAsync(userUser, userRole);
            //    }
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager) 
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Marko",
                    Email = "marko@test.com",
                    UserName = "marko@test.com",
                    Address = new Address
                    {
                        FirstName = "Marko",
                        LastName = "Brenjo",
                        Street = "Spasovdanska",
                        City = "Istocno Sarajevo",
                        ZipCode = "71123"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
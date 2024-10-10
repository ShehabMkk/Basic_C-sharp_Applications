using Microsoft.AspNetCore.Identity;
using Store.Data.Entities.IdentityEntities;

namespace Store.Repository;

public class StoreIdentityContextSeed
{
    public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new AppUser
            {
                DisplayName = "SHEHAB MKK",
                Email = "shehab.mkk2004@gmail.com",
                UserName = "shehabmkk",
                Address = new Address
                {
                    FirstName = "shehab",
                    LastName = "mkk",
                    Street = "123 Main Street",
                    City = "fayoum",
                    State = "fayoum",
                    PostalCode = "60131"
                }
            };
            await userManager.CreateAsync(user, "Password@123");
        }
    }
}
using Microsoft.AspNetCore.Identity;
using TourCompany.Models.Models;

namespace TourCompany.Pages
{
    public static class WebApplicationExtensions
    {
        public static async Task<WebApplication> CreateRolesAsync(this WebApplication app, IConfiguration configuration)
        {
            using var scope = app.Services.CreateScope();
            var roleManager = (RoleManager<IdentityRole>)scope.ServiceProvider.GetService(typeof(RoleManager<IdentityRole>));
            var userManager = scope.ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();
            var roles = configuration.GetSection("Roles").Get<List<String>>();
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            var adminEmail = configuration["SeedAdmin:Email"] ?? "admin@gmail.ie";
            var adminPassword = configuration["SeedAdmin:Password"] ?? "Admin123!";

            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (!result.Succeeded)
                {
                    // optional: log errors
                    return app;
                }
            }
            if (!await userManager.IsInRoleAsync(adminUser, "Admin"))
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }

            return app;

        }
    }

}

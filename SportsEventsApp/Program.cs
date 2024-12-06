using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Data;
using SportsEventsApp.Services.Implementations;
using SportsEventsApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<SportEventsAppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Configure Identity with Role support
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false; // Disable email confirmation
    options.User.RequireUniqueEmail = true; // Enforce unique email
    options.Password.RequireDigit = false; // Adjust password complexity
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequiredLength = 6; // Minimum password length
})
.AddEntityFrameworkStores<SportEventsAppDbContext>()
.AddDefaultTokenProviders();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add MVC Controllers and Views
builder.Services.AddControllersWithViews();

// Adding Razor Pages
builder.Services.AddRazorPages();

// Add custom services:
//Fight service
builder.Services.AddScoped<IFightService, FightService>();
//Fighter service
builder.Services.AddScoped<IFighterService, FighterService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedRolesAndAdminUser(services).GetAwaiter().GetResult();
}

app.Run();

static async Task SeedRolesAndAdminUser(IServiceProvider services)
{
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = services.GetRequiredService<UserManager<IdentityUser>>();

    // Define roles
    var roles = new[] { "User", "Admin" };

    // Ensure roles exist
    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }

    var config = services.GetRequiredService<IConfiguration>();
    var adminEmail = config["AdminUser:Email"];
    var adminPassword = config["AdminUser:Password"];

    if (await userManager.FindByEmailAsync(adminEmail) == null)
    {
        var adminUser = new IdentityUser
        {
            UserName = adminEmail,
            Email = adminEmail,
            EmailConfirmed = true
        };

        var createUserResult = await userManager.CreateAsync(adminUser, adminPassword);
        if (createUserResult.Succeeded)
        {
            await userManager.AddToRoleAsync(adminUser, "Admin");
        }
    }
}

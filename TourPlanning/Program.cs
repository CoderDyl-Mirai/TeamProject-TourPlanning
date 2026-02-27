using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Pages;
using TourCompany.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<TourDBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<TourDBContext>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login";
    options.AccessDeniedPath = "/AccessDenied";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
await app.CreateRolesAsync(builder.Configuration);

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NuGet.Configuration;
using ProyectoRestaurante.Data;
using ProyectoRestaurante.Helpers;
using ProyectoRestaurante.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<HelperPathProvider>();

string connectionString =
    builder.Configuration.GetConnectionString("SqlComanda");

builder.Services.AddTransient<RepositoryMenu>();


builder.Services.AddDbContext<RestauranteContext>
    (options => options.UseSqlServer(connectionString));


//SEGURIDAD
builder.Services.AddAuthentication(options =>
{
    options.DefaultSignInScheme =
    CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme =
    CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme =
    CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie();

// Add services to the container.
builder.Services.AddControllersWithViews(
    options => options.EnableEndpointRouting = false);

builder.Services.AddMemoryCache();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddResponseCaching();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{

   

    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseResponseCaching();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Managed}/{action=Login}/{id?}");

app.Run();

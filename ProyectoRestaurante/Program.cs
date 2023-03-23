using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NuGet.Configuration;
using ProyectoRestaurante.Data;
using ProyectoRestaurante.Repository;

var builder = WebApplication.CreateBuilder(args);

string connectionString =
    builder.Configuration.GetConnectionString("SqlComanda");

builder.Services.AddTransient<RepositoryMenu>();


builder.Services.AddDbContext<RestauranteContext>
    (options => options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Mesa}/{action=Mesa}/{id?}");

app.Run();

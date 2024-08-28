using Lab9TRKVD.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Create}/{id?}");
app.MapDefaultControllerRoute();
app.Run();

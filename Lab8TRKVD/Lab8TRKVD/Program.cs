var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
        name: "book",
        pattern: "BookStoreRoute",
        defaults: new { controller = "Book", action = "Index" });
app.MapControllerRoute(
        name: "book",
        pattern: "BookStoreRoute",
        defaults: new { controller = "Book", action = "Index" });
app.MapControllerRoute(
    name: "default1",
    pattern: "Store/{action}/{id?}",
    defaults: new { controller = "Home" });
app.MapControllerRoute(
    name: "default2",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Create",
    pattern: "Create",
    defaults: new { controller = "Home", action = "Create" });
app.Run();
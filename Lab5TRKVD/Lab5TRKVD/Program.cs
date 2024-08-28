var builder = WebApplication.CreateBuilder(args);
// додаЇмо п≥дтримку контролер≥в з у€вленн€ми
builder.Services.AddControllersWithViews();
var app = builder.Build();
// встановлюЇмо з≥ставленн€ маршрут≥в ≥з контролерами
app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "people",
    pattern: "people",
    defaults: new { controller = "Home", action = "People" });

app.Run();  
var builder = WebApplication.CreateBuilder(args);

// Додавання підтримки контролерів з поданнями

builder.Services.AddControllersWithViews();

var app = builder.Build();

// встановлюємо зіставлення маршрутів із контролерами

app.MapControllerRoute(
name: "additional_params",
pattern: "additional/{controller}/{action}");     //additional/Home/About

app.MapControllerRoute(
name: "static_segments",
pattern: "static/{controller=Home1}/{action=RoutingInfo}");      //static

app.MapControllerRoute(
    name: "default_values",
    pattern: "default/{controller=Home1}/{action=ControllersInfo}/{id?}");   //default/Home1/ControllersInfo

app.MapControllerRoute(
name: "with_defaults",
pattern: "{action}",
defaults: new { controller = "Home", action = "Index"});

app.Run();
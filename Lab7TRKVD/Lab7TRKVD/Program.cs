var builder = WebApplication.CreateBuilder(args);

// Добавление поддержки сессий
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

// Добавление поддержки контроллеров с представлениями
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Включение использования сессий
app.UseSession();

// Установка маршрута для контроллеров
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

var builder = WebApplication.CreateBuilder(args);
// ������ �������� ���������� � ����������
builder.Services.AddControllersWithViews();
var app = builder.Build();
// ������������ ���������� �������� �� ������������
app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "people",
    pattern: "people",
    defaults: new { controller = "Home", action = "People" });

app.Run();  
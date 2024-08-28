var builder = WebApplication.CreateBuilder(args);

// ���������� ��������� ������
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

// ���������� ��������� ������������ � ���������������
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ��������� ������������� ������
app.UseSession();

// ��������� �������� ��� ������������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

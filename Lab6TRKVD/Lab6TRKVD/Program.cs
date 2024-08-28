using Lab6TRKVD.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// �������� ����� ���������� � ���������������� �����
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
// ������ �������� ApplicationContext �� ����� � �������
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();

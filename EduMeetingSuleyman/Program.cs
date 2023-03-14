using EduMeetingSuleyman.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//Dependency Injection
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CS1")));
var app = builder.Build();
//middleware: istek cevap sürecini yönetmemizi yarar
if (!app.Environment.IsDevelopment()) app.UseStatusCodePagesWithReExecute("/hata/{0}");
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");
app.Run();

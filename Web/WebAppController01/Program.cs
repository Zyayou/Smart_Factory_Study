var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //MVC�������� ��� ��Ʈ�ѷ��� ���� ���
var app = builder.Build();
//app.MapDefaultControllerRoute();

//app.MapGet("/", () => "Hello World!");
//app.MapControllerRoute(name: "defult", pattern:"{controller=Home}/{action=Index}/{id?}");
//app.MapControllerRoute(name: "defult", pattern: "{controller=First}/{action=First}/{id?}");
//app.MapControllerRoute(name: "defult", pattern: "{controller=Home}/{action=About}/{id?}");

//app.MapControllerRoute(name: "defult", pattern: "{controller=User}/{action=Index}/{id?}");

app.MapControllers();//��Ʈ�ѷ� ���

app.Run();

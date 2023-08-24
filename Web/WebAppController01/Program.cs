var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //MVC패턴으로 뷰와 컨트롤러를 같이 사용
var app = builder.Build();
//app.MapDefaultControllerRoute();

//app.MapGet("/", () => "Hello World!");
//app.MapControllerRoute(name: "defult", pattern:"{controller=Home}/{action=Index}/{id?}");
//app.MapControllerRoute(name: "defult", pattern: "{controller=First}/{action=First}/{id?}");
//app.MapControllerRoute(name: "defult", pattern: "{controller=Home}/{action=About}/{id?}");

//app.MapControllerRoute(name: "defult", pattern: "{controller=User}/{action=Index}/{id?}");

app.MapControllers();//컨트롤러 사용

app.Run();

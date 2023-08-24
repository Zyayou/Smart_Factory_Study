using Microsoft.AspNetCore.Mvc.ApplicationParts;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//앱 초기화 후 설정
app.UseRouting();

app.MapGet("/", () => "Main Home Page");

/*
app.MapGet("/Home", () => "Hello World~! ~~Get");
app.MapPost("/Home", () => "Hello World~! ~~Post");
app.MapPut("/Home", () => "Hello World~! ~~Put");
app.MapDelete("/Home", () => "Hello World~! ~~Delet");
*/

/*
app.Run(async (HttpContext context) =>
{
    //한글깨짐 방지
    context.Response.ContentType = "text/html; charset=utf-8";
    //MainPage 입니다.
    await context.Response.WriteAsync("Main index Page 입니다.");
});
*/

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        //한글깨짐 방지
        context.Response.ContentType = "text/html; charset=utf-8";
        //MainPage 입니다.
        await context.Response.WriteAsync("Main index Page 입니다.");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Pist 입니다.");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Put 입니다.");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Delete 입니다.");
    });
});

app.Run();

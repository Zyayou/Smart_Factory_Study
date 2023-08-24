using Microsoft.AspNetCore.Mvc.ApplicationParts;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//�� �ʱ�ȭ �� ����
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
    //�ѱ۱��� ����
    context.Response.ContentType = "text/html; charset=utf-8";
    //MainPage �Դϴ�.
    await context.Response.WriteAsync("Main index Page �Դϴ�.");
});
*/

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        //�ѱ۱��� ����
        context.Response.ContentType = "text/html; charset=utf-8";
        //MainPage �Դϴ�.
        await context.Response.WriteAsync("Main index Page �Դϴ�.");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Pist �Դϴ�.");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Put �Դϴ�.");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Delete �Դϴ�.");
    });
});

app.Run();

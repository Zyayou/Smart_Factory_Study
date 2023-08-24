var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    context.Response.ContentType = "text/html; charset=utf-8"; //한글안깨지게
    await context.Response.WriteAsync("여기는 <b>메인페이지<b/> 입니다.\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("안녕하세요.\n");
    await next(context);
});


app.Run(async (context) =>
{
    //context.Response.ContentType = "text/plain; charset=utf-8"; //한글안깨지게 
    await context.Response.WriteAsync("Asp.Net Core 공부합시다~!");
});

app.Run();

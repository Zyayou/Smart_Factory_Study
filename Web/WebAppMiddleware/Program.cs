var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    context.Response.ContentType = "text/html; charset=utf-8"; //�ѱ۾ȱ�����
    await context.Response.WriteAsync("����� <b>����������<b/> �Դϴ�.\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("�ȳ��ϼ���.\n");
    await next(context);
});


app.Run(async (context) =>
{
    //context.Response.ContentType = "text/plain; charset=utf-8"; //�ѱ۾ȱ����� 
    await context.Response.WriteAsync("Asp.Net Core �����սô�~!");
});

app.Run();

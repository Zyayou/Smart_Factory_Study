var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string mainPage = "MainPage";
app.MapGet("/", () => "Hello World!");
app.MapGet("/Home", () => "�ݰ����ϴ�. <b>Home</b>Ȩ�Դϴ�.");
app.MapGet("/About", () => "About Page");

app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string mainPage = "MainPage";
app.MapGet("/", () => "Hello World!");
app.MapGet("/Home", () => "반갑습니다. <b>Home</b>홈입니다.");
app.MapGet("/About", () => "About Page");

app.Run();

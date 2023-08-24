var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();   //절대경로(?)

app.UseRouting();       //라우팅경로 ex)/home/index

app.UseAuthorization();

app.MapControllerRoute( //컨트롤 지정 
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

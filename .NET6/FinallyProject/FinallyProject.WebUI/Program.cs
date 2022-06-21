using FinallyProject.Business.Abstract;
using FinallyProject.Business.Concrete;
using FinallyProject.Data.Abstract;
using FinallyProject.Data.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var sqLiteCon = builder.Configuration.GetConnectionString("SqLite");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(sqLiteCon));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

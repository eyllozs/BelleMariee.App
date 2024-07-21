
using BelleMariee.App.DataAccess.Contexts;
using BelleMariee.App.Service.Interfaces;
using BelleMariee.App.Service.Extensions;
using BelleMariee.App.Service.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using BelleMariee.App.Entity.Services;
using BelleMariee.App.Mapping;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddDbContext<BelleDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr"))
);

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddScoped<ISaleService, SaleService>();
builder.Services.AddScoped<IProductSaleDetailsService, ProductSaleDetailsService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddExtensions();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "areas",
    pattern: "{controller=Home}/{action=Index}/{id?}/{area=Admin}");

app.MapControllerRoute(
    name: "area",
    pattern: "{controller=Home}/{action=Index}/{area=Admin}");

app.Run();

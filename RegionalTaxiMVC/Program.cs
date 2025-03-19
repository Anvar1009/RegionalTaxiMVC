using Microsoft.EntityFrameworkCore;
using RegionalTaxiMVC.DB_Regtaxi;
using RegionalTaxiMVC.Models;
using RegionalTaxiMVC.Repositories;
using RegionalTaxiMVC.Repositories.Interfaces;
using RegionalTaxiMVC.Services;
using RegionalTaxiMVC.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RegTaxiDBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Host=localhost; Port=5432; User id=postgres; Database=RegtaxiMVC; Password=anvar1009; Include Error Detail=true;")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICarServices, CarService>();
builder.Services.AddScoped<ICarRepository, CarRepository>();
//builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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

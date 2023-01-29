using Microsoft.EntityFrameworkCore;
using NLMKTest.Domain;
using NLMKTest.Domain.Repos.Classes;
using NLMKTest.Domain.Repos.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection"), b =>
    b.UseOracleSQLCompatibility("11")));
builder.Services.AddScoped<IEquipmentDowntimeRepo, EquipmentDowntimeRepo>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
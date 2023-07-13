using Microsoft.EntityFrameworkCore;
using pdc.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<pdc.Models.L1231.L1231Context>(options =>
    options.UseSqlServer(builder.Configuration
    .GetConnectionString("l1231ConnectionString")));
builder.Services.AddDbContext<pdc.Models.T527.T527Context>(options =>
    options.UseSqlServer(builder.Configuration
    .GetConnectionString("t527ConnectionString")));
builder.Services.AddDbContext<pdc.Models.T541.T541Context>(options =>
    options.UseSqlServer(builder.Configuration
    .GetConnectionString("t541ConnectionString")));
builder.Services.AddDbContext<pdc.Models.T543.T543Context>(options =>
    options.UseSqlServer(builder.Configuration
    .GetConnectionString("t543ConnectionString")));
builder.Services.AddDbContext<pdc.Models.Lichsu.CheckPalletPDCContext>(options =>
    options.UseSqlServer(builder.Configuration
    .GetConnectionString("lichsuConnectionString")));

// Add services to the container.
builder.Services.AddControllersWithViews();
//Using session
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

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
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Login}/{id?}");

app.Run();
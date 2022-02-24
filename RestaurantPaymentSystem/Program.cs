using Microsoft.EntityFrameworkCore;
using RestaurantPaymentSystem.Data;
using RestaurantPaymentSystem.Data.Repositories;
using RestaurantPaymentSystem.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

builder.Services.AddScoped<IDishService, DishService>();
builder.Services.AddScoped<ITableService, TableService>();
builder.Services.AddDbContext<RestaurantContext>(options => options.UseSqlServer(configuration.GetConnectionString("restoConnectionstring"),
                b => b.MigrationsAssembly(typeof(RestaurantContext).Assembly.FullName)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate.Models;
using RealEstate.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HomeContext>(opt => opt.UseSqlite("Data Source=realestate.db"));

builder.Services.AddScoped<HomeService>();
builder.Services.AddRazorPages(options =>
{
    options.Conventions.ConfigureFilter(new IgnoreAntiforgeryTokenAttribute());
});

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<HomeContext>();
    dbContext.Database.EnsureDeleted();
    dbContext.Database.EnsureCreated();
}

app.UseStaticFiles();

app.MapRazorPages();

app.Run();

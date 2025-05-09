using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Umut2000.DataAccess.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var mongoDatabase = new MongoClient(builder.Configuration.GetConnectionString("MongoConnection")).GetDatabase(builder.Configuration.GetSection("DatabaseName").Value);

builder.Services.AddDbContext<UmutContext>(options =>
{
    options.UseMongoDB(mongoDatabase.Client, mongoDatabase.DatabaseNamespace.DatabaseName);
});

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
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

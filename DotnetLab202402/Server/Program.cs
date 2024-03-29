using DotnetLab202402.Server.Model;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContextPool<Context>(options =>
{
    DbContextOptionsBuilder dbContextOptionsBuilder = options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Dotnetlab202402;Trusted_Connection=True;",
        sqlServerOptionsAction: Sqloption =>
        {
            Sqloption.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null
                );
            Sqloption.CommandTimeout(30);
        });
    options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

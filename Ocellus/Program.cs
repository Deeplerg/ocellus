using Ocellus.Components;
using Ocellus.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ships.json");

// Add services to the container.
builder.Services.AddRazorComponents();
builder.Services.Configure<ShipOptions>(builder.Configuration.GetSection(ShipOptions.Position));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();
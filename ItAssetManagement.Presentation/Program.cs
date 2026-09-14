using ItAssetManagement.Application.Assets;
using ItAssetManagement.Application.Locations.Services;
using ItAssetManagement.Domain.Locations;
using ItAssetManagement.Infrastructure.Assets.Presistance;
using ItAssetManagement.Infrastructure.Locations.InMemory;
using ItAssetManagement.Presentation.Assets;
using ItAssetManagement.Presentation.Locations.Dialog;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<ILocationRepository, InMemoryLocationRepository>();
builder.Services.AddSingleton<IAssetRepository, InMemoryAssetRepository>();

builder.Services.AddTransient<IAssetService, AssetService>();
builder.Services.AddTransient<ILocationService, LocationService>();
builder.Services.AddTransient<ILocationDialog, LocationDialog>();
builder.Services.AddTransient<IAssetDialog, AssetDialog>();
builder.Services.AddTransient<LocationMenu>();
builder.Services.AddTransient<MainMenu>();

var app = builder.Build();

var menuDialog = app.Services.GetRequiredService<MainMenu>();
menuDialog.ShowMainMenu();


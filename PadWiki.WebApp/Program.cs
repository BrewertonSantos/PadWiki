using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PadWiki.WebApp;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.JSInterop;
using PadWiki.WebApp.Extensions;
using PadWiki.WebApp.Middlewares;
using PadWiki.WebApp.Services;
using PadWiki.WebApp.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSingleton<ICardService, CardService>();
builder.Services.AddSingleton<ICharmService, CharmService>();

// Adicionar serviços de localização
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.RootComponents.Add<App>("#app");

builder.Services.AddTransient<CacheControlMiddleware>(provider =>
    new CacheControlMiddleware(provider.GetRequiredService<RequestDelegate>(), new Uri(builder.HostEnvironment.BaseAddress)));

builder.Services.AddMudServices();

WebAssemblyHost host = builder.Build();
IJSRuntime jsInterop = host.Services.GetRequiredService<IJSRuntime>();
string? result = await jsInterop.InvokeAsync<string>("blazorCulture.get");

CultureInfo culture;

if (result is not null) culture = new CultureInfo(result);
else culture = new CultureInfo("en-US");

await host.SetDefaultCulture();

CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;
await host.RunAsync();
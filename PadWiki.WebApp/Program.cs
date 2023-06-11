using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PadWiki.WebApp;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddLocalization();
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("en-US"),
        new CultureInfo("es-MX"),
        new CultureInfo("pl-PL"),
        new CultureInfo("pt-BR"),
        new CultureInfo("pt-PT"),
        new CultureInfo("ru-RU")
    };

    CultureInfo.DefaultThreadCurrentCulture = supportedCultures[0];
    CultureInfo.DefaultThreadCurrentUICulture = supportedCultures[0];
    CultureInfo.CurrentCulture = supportedCultures[0];
    CultureInfo.CurrentUICulture = supportedCultures[0];
    options.DefaultRequestCulture = new RequestCulture("en-US");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

var host = builder.Build();
builder.Services.AddLocalization(options => options.ResourcesPath = "Greeting");

await host.RunAsync();

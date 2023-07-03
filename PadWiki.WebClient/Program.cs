using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using PadWiki.WebClient.Services;
using PadWiki.WebClient.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSingleton<ICardService, CardService>();
builder.Services.AddSingleton<ICharmService, CharmService>();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
var supportedCultures = new[] { new CultureInfo("en-US"), new CultureInfo("pt-BR") };
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("pt-BR");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});
await builder.Build().RunAsync();
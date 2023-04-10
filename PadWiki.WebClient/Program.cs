using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PadWiki.WebClient;
using PadWiki.WebClient.Services;
using PadWiki.WebClient.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSingleton<IPokemonCardsService, PokemonCardsService>();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

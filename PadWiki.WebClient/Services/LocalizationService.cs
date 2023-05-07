using System.Reflection;
using Microsoft.Extensions.Localization;
using PadWiki.WebClient.Data.Globalization.Shared;

namespace PadWiki.WebClient.Services;

public class LocalizationService
{
    private readonly IStringLocalizer _localizer;

    public LocalizationService(IStringLocalizerFactory factory)
    {
        var type = typeof(SharedResources);
        var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
        _localizer = factory.Create("SharedResources", assemblyName.Name);
    }

    public string GetLocalizedHtml(string key) => _localizer[key];
}
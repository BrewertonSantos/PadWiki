using System.ComponentModel;
using System.Reflection;
using System.Resources;
using PadWiki.WebApp.Resources;

namespace PadWiki.WebApp.Extensions;

public static class EnumExtensions
{
    public static string? GetDescription(this Enum value)
    {
        FieldInfo? fieldInfo = value.GetType().GetField(value.ToString());

        if (fieldInfo is null) return value.ToString();
        DescriptionAttribute? attribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();

        if (attribute == null) return value.ToString();
        ResourceManager resourceManager = new ResourceManager(typeof(EnumResources));
        return resourceManager.GetString(attribute.Description);
    }
}
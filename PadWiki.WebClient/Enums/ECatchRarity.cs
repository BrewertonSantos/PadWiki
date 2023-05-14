using System.ComponentModel;

namespace PadWiki.WebClient.Enums;

/// <summary>
/// Represents the catch rarity of a Pokemon.
/// </summary>
public enum ECatchRarity
{
    [Description("Easy")]
    Easy = 0,
    
    [Description("Normal")]
    Normal = 1,
    
    [Description("Medium")]
    Medium = 2,
    
    [Description("Rare")]
    Rare = 3,
    
    [Description("VeryRare")]
    VeryRare = 4
}
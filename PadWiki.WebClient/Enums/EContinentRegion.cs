using System.ComponentModel;

namespace PadWiki.WebClient.Enums;

/// <summary>
/// Represents the regions of continents in the Pokémon world.
/// </summary>
public enum EContinentRegion
{
    [Description("Alola region, located on a tropical island.")]
    Alola,
    
    [Description("Galar region, a region inspired by Great Britain.")]
    Galar,
    
    [Description("Hoenn region, known for its diverse and challenging landscapes.")]
    Hoenn,
    
    [Description("Johto region, a region rich in history and with a variety of habitats.")]
    Johto,
    
    [Description("Kalos region, a beautiful and sophisticated region with French influences.")]
    Kalos,
    
    [Description("Kanto region, the first region introduced in Pokémon games.")]
    Kanto,
    
    [Description("Sinnoh region, known for its cold climate and explored in fourth-generation games.")]
    Sinnoh,
    
    [Description("Unova region, a diverse and modern region introduced in fifth-generation games.")]
    Unova
}
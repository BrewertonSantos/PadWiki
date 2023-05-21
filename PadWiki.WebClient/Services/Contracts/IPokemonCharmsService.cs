using PadWiki.WebClient.Entities;

namespace PadWiki.WebClient.Services.Contracts;

/// <summary>
/// Defines the basic structure for a service that manages a collection of Pokémon charms.
/// </summary>
public interface IPokemonCharmsService
{
    List<Charm> Charms { get; set; }
    
    /// <summary>
    /// Responsible for populating the Pokémon charms list with existing charms.
    /// </summary>
    void PopulatePokemonCharms();
}
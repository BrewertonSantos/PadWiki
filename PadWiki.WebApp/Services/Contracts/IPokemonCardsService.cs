using PadWiki.WebApp.Entities;

namespace PadWiki.WebApp.Services.Contracts;

/// <summary>
/// Defines the basic structure for a service that manages a collection of Pokémon trading cards.
/// </summary>
public interface IPokemonCardsService
{
    /// <summary>
    /// Stores all necessary information of a Pokémon trading card and among other characteristics that may be relevant in the context.
    /// </summary>
    List<TradingCard> Cards { get; set; }

    /// <summary>
    /// Responsible for populating the Cards list with the available Pokémon trading cards.
    /// </summary>
    void PopulatePokemonCards();
}
using PadWiki.WebClient.Entities;

namespace PadWiki.WebClient.Services.Contracts;

public interface IPokemonCardsService
{
    List<TradingCard> Cards { get; set; }

    void PopulatePokemonCards();
}
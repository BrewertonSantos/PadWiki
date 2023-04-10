using PadWiki.WebClient.Entities;

namespace PadWiki.WebClient.Services.Contracts;

public interface IPokemonCardsService
{
    List<PokemonCard> Cards { get; set; }

    void PopulatePokemonCards();
}
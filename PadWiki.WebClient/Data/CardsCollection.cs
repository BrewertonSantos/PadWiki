using PadWiki.WebClient.Entities;
using PadWiki.WebClient.Enums;

namespace PadWiki.WebClient.Data;

public static class CardsCollection
{
    public static List<PokemonCard> Cards { get; } = new();

    static CardsCollection() => PopulateCards();

    static void PopulateCards()
    {
        Cards.Add(new PokemonCard(3, "/lib/images/pokemon-cards/3-alakazam-x.png", "Alakazam (*)", ECardRarity.Normal, "A common card.", EDropRarity.Regular, 1));
    }
}
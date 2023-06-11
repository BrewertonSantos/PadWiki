using PadWiki.WebApp.Entities;
using PadWiki.WebApp.Enums;
using PadWiki.WebApp.Services.Contracts;

namespace PadWiki.WebApp.Services;

public class PokemonCardsService : IPokemonCardsService
{
    public List<TradingCard> Cards { get; set; }

    public PokemonCardsService()
    {
        Cards = new();
        PopulatePokemonCards();
    }
    
    public void PopulatePokemonCards()
    {
        Cards.Add(new TradingCard(2, "/lib/images/pokemon-cards/2-aerodactyl-x.png", "Aerodactyl (*)", ECardRarity.Normal, "Can be obtained by looting Aerodactyl, through the mixer or trading with players.", EDropRarity.VeryRare));
        Cards.Add(new TradingCard(3, "/lib/images/pokemon-cards/3-alakazam-x.png", "Alakazam (*)", ECardRarity.Normal, "Can be obtained by looting Alakazam, through the mixer or trading with players.", EDropRarity.VeryRare));
        Cards.Add(new TradingCard(22, "/lib/images/pokemon-cards/22-arbok-x.png", "Arbok (*)", ECardRarity.Normal, "Can be obtained by looting Arbok, through the mixer or trading with players.", EDropRarity.VeryRare));
        Cards.Add(new TradingCard(23, "/lib/images/pokemon-cards/23-arcanine-x.png", "Arcanine (*)", ECardRarity.Normal, "Can be obtained in Private Fire Island, through the mixer or trading with players.", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(24, "/lib/images/pokemon-cards/24-articuno-x.png", "Articuno (*)", ECardRarity.Normal, "", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(25, "/lib/images/pokemon-cards/25-beedrill-x.png", "Beedrill (*)", ECardRarity.Normal, "Can be obtained by looting Beedrill, through the mixer or trading with players.", EDropRarity.VeryRare));
        Cards.Add(new TradingCard(26, "/lib/images/pokemon-cards/26-bellsprout-x.png", "Bellsprout (*)", ECardRarity.Normal, "Can be obtained by looting Bellsprout, through the mixer or trading with players.", EDropRarity.Rare));
        Cards.Add(new TradingCard(28, "/lib/images/pokemon-cards/28-bulbasaur-x.png", "Bulbasaur (*)", ECardRarity.Normal, "", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(30, "/lib/images/pokemon-cards/30-caterpie-x.png", "Caterpie (*)", ECardRarity.Normal, "Can be obtained by looting Caterpie, through the mixer or trading with players.", EDropRarity.Rare));
        Cards.Add(new TradingCard(33, "/lib/images/pokemon-cards/33-charizard-x.png", "Charizard (*)", ECardRarity.Normal, "Can be obtained by looting Charizard, through the mixer or trading with players.", EDropRarity.VeryRare));
        Cards.Add(new TradingCard(34, "/lib/images/pokemon-cards/34-charmander-x.png", "Charmander (*)", ECardRarity.Normal, "Can be obtained by hatching a Charmander Egg, through the mixer or trading with players.", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(36, "/lib/images/pokemon-cards/36-clefairy-x.png", "Clefairy (*)", ECardRarity.Normal, "A common card.", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(37, "/lib/images/pokemon-cards/37-cloyster-x.png", "Cloyster (*)", ECardRarity.Normal, "Can be obtained opening an Cloyster corpse, through the mixer or trading with players.", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(38, "/lib/images/pokemon-cards/38-cubone-x.png", "Cubone (*)", ECardRarity.Normal, "Can be obtained through the mixer or trading with players.", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(39, "/lib/images/pokemon-cards/39-dewgong-x.png", "Dewgong (*)", ECardRarity.Normal, "Can be obtained by looting Dewgong, through the mixer or trading with players.", EDropRarity.VeryRare));
        Cards.Add(new TradingCard(43, "/lib/images/pokemon-cards/43-doduo-x.png", "Doduo (*)", ECardRarity.Normal, "Can be obtained in trovitopolis mountains, through the mixer or trading with players.", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(44, "/lib/images/pokemon-cards/44-dragonair-x.png", "Dragonair (*)", ECardRarity.Normal, "Can be obtained by looting Dragonair, through the mixer or trading with players.", EDropRarity.VeryRare));
        Cards.Add(new TradingCard(45, "/lib/images/pokemon-cards/45-dragonite-x.png", "Dragonite (*)", ECardRarity.Normal, "Can be obtained through the mixer or trading with players.", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(46, "/lib/images/pokemon-cards/46-dratini-x.png", "Dratini (*)", ECardRarity.Normal, "Can be obtained by achievement (Receiving Dratini from Kanto Box 2) through the mixer or trading with players.", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(47, "/lib/images/pokemon-cards/47-drowzee-x.png", "Drowzee (*)", ECardRarity.Normal, "Can be obtained by looting Drowzee, through the mixer or trading with players.", EDropRarity.VeryRare));
        Cards.Add(new TradingCard(48, "/lib/images/pokemon-cards/48-dugtrio-x.png", "Dugtrio (*)", ECardRarity.Normal, "Can be obtained by looting Drowzee, through the mixer or trading with players.", EDropRarity.VeryRare));
        Cards.Add(new TradingCard(49, "/lib/images/pokemon-cards/49-eevee-x.png", "Eevee (*)", ECardRarity.Normal, "Can be obtained by achievement (hatching 10 Eevee Eggs), through the mixer or trading with players.", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(50, "/lib/images/pokemon-cards/50-ekans-x.png", "Ekans (*)", ECardRarity.Normal, "Can be obtained through the mixer or trading with players.", EDropRarity.Unavailable));
        Cards.Add(new TradingCard(52, "/lib/images/pokemon-cards/52-electabuzz-x.png", "Electabuzz (*)", ECardRarity.Normal, "Can be obtained by looting Electabuzz, through the mixer or trading with players.", EDropRarity.VeryRare));
        Cards.Add(new TradingCard(53, "/lib/images/pokemon-cards/53-electivire-x.png", "Electivire (*)", ECardRarity.Normal, "", EDropRarity.Unavailable));
    }
}
using PadWiki.WebClient.Entities;
using PadWiki.WebClient.Services.Contracts;

namespace PadWiki.WebClient.Services;

public class PokemonCharmsService : IPokemonCharmsService
{
    public List<Charm> Charms { get; set; }

    public PokemonCharmsService()
    {
        Charms = new();
        PopulatePokemonCharms();
    }

    public void PopulatePokemonCharms()
    {
        Charms.Add(new Charm(
            "Catch Charm",
            1,
            "",
            "",
            "https://imgur.com/lJ2QNwc.png",
            ""));
        Charms.Add(new Charm("Cure Charm", 1, "", "", "https://imgur.com/FQFCpFl.png", ""));
        Charms.Add(new Charm("Defense Charm", 1, "", "", "https://imgur.com/aJyov0p.png", ""));
        
        Charms.Add(new Charm(
            "Dodge Charm",
            boostLevelAndValueInPercentage: new int[3,3]{{1, 3, 5}, {6, 7, 8}, {9, 12, 15}},
            "User has a percentage chance to dodge one random move from task pokemon.",
            1,
            "https://imgur.com/MhanFgG.png",
            pveCooldownInSeconds: 60,
            pvpCooldownInSeconds: 60,
            secondBoostValueInPercentage: 3,
            thirdBoostValueInPercentage: 5,
            usageInfo: "",
            worksInPve: true,
            worksInPvp: true));
        Charms.Add(new Charm("Experience Charm", 1, "", "", "https://imgur.com/MsQeGD9.png", ""));
        Charms.Add(new Charm("Fire Charm", 1, "", "", "https://imgur.com/Osldnkc.png", ""));
        Charms.Add(new Charm("Lucky Charm", 1, "", "", "https://imgur.com/7QfJS4w.png", ""));
        Charms.Add(new Charm("Mimic Charm", 1, "", "", "https://imgur.com/dMBEkLK.png", ""));
        Charms.Add(new Charm("Power Charm", 1, "", "", "https://imgur.com/66kb6Zc.png", ""));
        Charms.Add(new Charm("Stunning Charm", 1, "", "", "https://imgur.com/pPIRwKr.png", ""));
        Charms.Add(new Charm("Vital Charm", 1, "", "", "https://imgur.com/of7QjOX.png", ""));
        Charms.Add(new Charm("Wealth Charm", 1, "", "", "https://imgur.com/IB6A8iI.png", ""));
    }
}
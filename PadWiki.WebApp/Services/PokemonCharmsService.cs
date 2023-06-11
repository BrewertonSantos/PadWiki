using PadWiki.WebApp.Entities;
using PadWiki.WebApp.Services.Contracts;

namespace PadWiki.WebApp.Services;

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
            name: "Catch Charm",
            firstLevelFirstBoost: 0,
            firstLevelSecondBoost: 0,
            firstLeveThirdBoost: 0,
            secondLevelFirstBoost: 0,
            secondLevelSecondBoost: 0,
            secondLeveThirdBoost: 0,
            thirdLevelFirstBoost: 1,
            thirdLevelSecondBoost: 5,
            thirdLeveThirdBoost: 10,
            description: "Gives a percentage extra chance to catch rate.",
            "https://imgur.com/lJ2QNwc.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: "Affect only tasked Pokémon.",
            worksInPve: true,
            worksInPvp: false));

        Charms.Add(new Charm(
            name: "Cure Charm",
            firstLevelFirstBoost: 0,
            firstLevelSecondBoost: 0,
            firstLeveThirdBoost: 0,
            secondLevelFirstBoost: 0,
            secondLevelSecondBoost: 0,
            secondLeveThirdBoost: 0,
            thirdLevelFirstBoost: 1,
            thirdLevelSecondBoost: 5,
            thirdLeveThirdBoost: 10,
            description:
            "Gives an percentage chance that enemy will heal the user instead of dealing damage with 1 random spell.",
            "https://imgur.com/FQFCpFl.png",
            pveCooldownInSeconds: 30,
            pvpCooldownInSeconds: 30,
            usageInfo: "User or tasked Pokémon.",
            worksInPve: true,
            worksInPvp: true));

        Charms.Add(new Charm(
            name: "Defense Charm",
            firstLevelFirstBoost: 1,
            firstLevelSecondBoost: 2,
            firstLeveThirdBoost: 3,
            secondLevelFirstBoost: 4,
            secondLevelSecondBoost: 5,
            secondLeveThirdBoost: 6,
            thirdLevelFirstBoost: 7,
            thirdLevelSecondBoost: 8,
            thirdLeveThirdBoost: 10,
            description: "Tasked Pokémon deals a percentage less damage to the user.",
            "https://imgur.com/aJyov0p.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: "Tasked Pokémon.",
            worksInPve: true,
            worksInPvp: false));

        Charms.Add(new Charm(
            name: "Dodge Charm",
            firstLevelFirstBoost: 1,
            firstLevelSecondBoost: 3,
            firstLeveThirdBoost: 5,
            secondLevelFirstBoost: 6,
            secondLevelSecondBoost: 7,
            secondLeveThirdBoost: 8,
            thirdLevelFirstBoost: 9,
            thirdLevelSecondBoost: 12,
            thirdLeveThirdBoost: 15,
            description: "User has a percentage chance to dodge one random move from tasked Pokémon.",
            "https://imgur.com/MhanFgG.png",
            pveCooldownInSeconds: 60,
            pvpCooldownInSeconds: 60,
            usageInfo: "User or Tasked Pokémon.",
            worksInPve: true,
            worksInPvp: true));

        Charms.Add(new Charm(
            name: "Experience Charm",
            firstLevelFirstBoost: 1,
            firstLevelSecondBoost: 3,
            firstLeveThirdBoost: 4,
            secondLevelFirstBoost: 5,
            secondLevelSecondBoost: 6,
            secondLeveThirdBoost: 7,
            thirdLevelFirstBoost: 8,
            thirdLevelSecondBoost: 9,
            thirdLeveThirdBoost: 12,
            description: "Gives a percentage extra experience.",
            "https://imgur.com/MsQeGD9.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: "User or tasked Pokémon.",
            worksInPve: true,
            worksInPvp: false));

        Charms.Add(new Charm(
            name: "Fire Charm",
            firstLevelFirstBoost: 0,
            firstLevelSecondBoost: 0,
            firstLeveThirdBoost: 0,
            secondLevelFirstBoost: 0,
            secondLevelSecondBoost: 0,
            secondLeveThirdBoost: 0,
            thirdLevelFirstBoost: 1,
            thirdLevelSecondBoost: 5,
            thirdLeveThirdBoost: 10,
            description:
            "Has a percentage chances for the user to hit 20% damage through immunities, including abilities.",
            "https://imgur.com/Osldnkc.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: "User.",
            worksInPve: true,
            worksInPvp: true));

        Charms.Add(new Charm(
            name: "Lucky Charm",
            firstLevelFirstBoost: 1,
            firstLevelSecondBoost: 3,
            firstLeveThirdBoost: 5,
            secondLevelFirstBoost: 6,
            secondLevelSecondBoost: 8,
            secondLeveThirdBoost: 10,
            thirdLevelFirstBoost: 11,
            thirdLevelSecondBoost: 14,
            thirdLeveThirdBoost: 20,
            description: "Gives a percentage chance to drop items.",
            "https://imgur.com/7QfJS4w.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: "Tasked Pokémon.",
            worksInPve: true,
            worksInPvp: false));

        Charms.Add(new Charm(
            name: "Mimic Charm",
            firstLevelFirstBoost: 1,
            firstLevelSecondBoost: 2,
            firstLeveThirdBoost: 3,
            secondLevelFirstBoost: 4,
            secondLevelSecondBoost: 5,
            secondLeveThirdBoost: 6,
            thirdLevelFirstBoost: 8,
            thirdLevelSecondBoost: 10,
            thirdLeveThirdBoost: 12,
            description: "Gives a percentage chance to use 1 random spell of enemy.",
            "https://imgur.com/dMBEkLK.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 60,
            usageInfo: "User or tasked Pokémon.",
            worksInPve: true,
            worksInPvp: true));

        Charms.Add(new Charm(
            name: "Power Charm",
            firstLevelFirstBoost: 1,
            firstLevelSecondBoost: 2,
            firstLeveThirdBoost: 4,
            secondLevelFirstBoost: 5,
            secondLevelSecondBoost: 6,
            secondLeveThirdBoost: 7,
            thirdLevelFirstBoost: 8,
            thirdLevelSecondBoost: 9,
            thirdLeveThirdBoost: 10,
            description: "Deals a percentage more damage to the tasked Pokémon.",
            "https://imgur.com/66kb6Zc.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: "Tasked Pokémon.",
            worksInPve: true,
            worksInPvp: false));

        Charms.Add(new Charm(
            name: "Stunning Charm",
            firstLevelFirstBoost: 0,
            firstLevelSecondBoost: 0,
            firstLeveThirdBoost: 0,
            secondLevelFirstBoost: 0,
            secondLevelSecondBoost: 0,
            secondLeveThirdBoost: 0,
            thirdLevelFirstBoost: 1,
            thirdLevelSecondBoost: 5,
            thirdLeveThirdBoost: 10,
            description: "Gives a percentage chance to stun enemy with any spell used by this Pokémon for 2 seconds.",
            "https://imgur.com/pPIRwKr.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: "User.",
            worksInPve: true,
            worksInPvp: false));

        Charms.Add(new Charm(
            name: "Vital Charm",
            firstLevelFirstBoost: 1,
            firstLevelSecondBoost: 3,
            firstLeveThirdBoost: 5,
            secondLevelFirstBoost: 6,
            secondLevelSecondBoost: 7,
            secondLeveThirdBoost: 9,
            thirdLevelFirstBoost: 10,
            thirdLevelSecondBoost: 12,
            thirdLeveThirdBoost: 15,
            description: "Gives a percentage chance that enemy's stun won't be effective.",
            "https://imgur.com/of7QjOX.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: "User or tasked Pokémon. On PvP works only on tasked Pokémon.",
            worksInPve: true,
            worksInPvp: true));

        Charms.Add(new Charm(
            name: "Wealth Charm",
            firstLevelFirstBoost: 1,
            firstLevelSecondBoost: 2,
            firstLeveThirdBoost: 3,
            secondLevelFirstBoost: 4,
            secondLevelSecondBoost: 5,
            secondLeveThirdBoost: 6,
            thirdLevelFirstBoost: 7,
            thirdLevelSecondBoost: 13,
            thirdLeveThirdBoost: 20,
            description: "Gives a percentage chance to drop additional loot.",
            "https://imgur.com/IB6A8iI.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: "",
            worksInPve: true,
            worksInPvp: false));
    }
}
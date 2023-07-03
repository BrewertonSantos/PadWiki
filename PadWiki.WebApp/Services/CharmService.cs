using PadWiki.WebApp.Entities;
using PadWiki.WebApp.Enums;
using PadWiki.WebApp.Services.Contracts;

namespace PadWiki.WebApp.Services;

public class CharmService : ICharmService
{
    public List<Charm> Charms { get; set; }

    public CharmService()
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
            description: new(
                englishUsa: "Gives a percentage extra chance to catch rate.",
                polishPoland: "Zapewnia dodatkową szansę w procentach na wskaźnik złapania.",
                portugueseBrazil: "Fornece uma chance extra em porcentagem para a taxa de captura.",
                portuguesePortugal: "Dá uma chance extra em percentagem para a taxa de captura.",
                russianRussia: "Дает дополнительный процент шанса на поймать.",
                spanishMexico: "Otorga un porcentaje adicional de probabilidad para la tasa de captura."),
            "https://imgur.com/lJ2QNwc.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: new(
                "Affect only tasked Pokémon.",
                "Dotyczy tylko przydzielonych Pokémonów.",
                "Afeta apenas Pokémon designados.",
                "Afeta apenas Pokémon designados.",
                "Влияет только на назначенных покемонов.",
                "Afecta solo a Pokémon asignados."),
            worksOn: EPlayerCreatureEffect.PvEOnly));

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
            description: new(
                "Gives an percentage chance that enemy will heal the user instead of dealing damage with 1 random spell.",
                "Zapewnia szansę w procentach, że przeciwnik uleczy użytkownika zamiast zadawać mu obrażenia jednym losowym czarem.",
                "Fornece uma chance em porcentagem de que o inimigo cure o usuário em vez de causar dano com 1 feitiço aleatório.",
                "Dá uma probabilidade em percentagem de o inimigo curar o utilizador em vez de causar dano com 1 feitiço aleatório.",
                "Дает процентный шанс тому, что враг вместо нанесения урона случайным заклинанием излечит пользователя.",
                "Otorga una probabilidad en porcentaje de que el enemigo cure al usuario en lugar de infligirle daño con un hechizo aleatorio."),
            "https://imgur.com/FQFCpFl.png",
            pveCooldownInSeconds: 30,
            pvpCooldownInSeconds: 30,
            usageInfo: new(
                "User or tasked Pokémon.",
                "Użytkownik lub przydzielony Pokémon.",
                "Usuário ou Pokémon designado.",
                "Utilizador ou Pokémon designado.",
                "Пользователь или назначенный покемон.",
                "Usuario o Pokémon asignado."),
            worksOn: EPlayerCreatureEffect.PvEAndPvP));

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
            description: new(
                "Tasked Pokémon deals a percentage less damage to the user.",
                "Przydzielony Pokémon zadaje procentowo mniejsze obrażenia użytkownikowi.",
                "O Pokémon designado causa um percentual a menos de dano ao usuário.",
                "O Pokémon designado causa um percentual a menos de dano ao utilizador.",
                "Назначенный Покемон наносит процентно меньший урон пользователю.",
                "El Pokémon asignado inflige un porcentaje menos de daño al usuario."),
            "https://imgur.com/aJyov0p.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: new(
                "Tasked Pokémon.",
                "Przydzielony Pokémon.",
                "Pokémon designado.",
                "Pokémon designado.",
                "Назначенный покемон.",
                "Pokémon asignado."),
            worksOn: EPlayerCreatureEffect.PvEOnly));

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
            description: new(
                "User has a percentage chance to dodge one random move from tasked Pokémon.",
                "Użytkownik ma szansę w procentach na uniknięcie jednego losowego ruchu od przypisanego Pokémona.",
                "O usuário tem uma chance em porcentagem de desviar de um movimento aleatório do Pokémon designado.",
                "O usuário tem uma chance em porcentagem de desviar de um movimento aleatório do Pokémon designado.",
                "У пользователя есть процентный шанс уклониться от одного случайного движения у назначенного Покемона.",
                "El usuario tiene una probabilidad en porcentaje de esquivar un movimiento aleatorio del Pokémon asignado."),
            "https://imgur.com/MhanFgG.png",
            pveCooldownInSeconds: 60,
            pvpCooldownInSeconds: 60,
            usageInfo: new(
                "User or tasked Pokémon.",
                "Użytkownik lub przydzielony Pokémon.",
                "Usuário ou Pokémon designado.",
                "Utilizador ou Pokémon designado.",
                "Пользователь или назначенный покемон.",
                "Usuario o Pokémon asignado."),
            worksOn: EPlayerCreatureEffect.PvEAndPvP));

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
            description: new(
                "Gives a percentage extra experience.",
                "Zapewnia dodatkowe doświadczenie w procentach.",
                "Fornece uma experiência extra em porcentagem.",
                "Dá uma experiência extra em percentagem.",
                "Дает дополнительный процент опыта.",
                "Otorga una experiencia extra en porcentaje."),
            "https://imgur.com/MsQeGD9.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: new(
                "User or tasked Pokémon.",
                "Użytkownik lub przydzielony Pokémon.",
                "Usuário ou Pokémon designado.",
                "Utilizador ou Pokémon designado.",
                "Пользователь или назначенный покемон.",
                "Usuario o Pokémon asignado."),
            worksOn: EPlayerCreatureEffect.PvEOnly));

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
            description: new(
                "Has a percentage chances for the user to hit 20% damage through immunities, including abilities.",
                "Ma szansę w procentach na to, że użytkownik zada obrażenia w wysokości 20% pomimo odporności, włączając w to zdolności.",
                "Tem uma chance em porcentagem para que o usuário cause 20% de dano através de imunidades, incluindo habilidades.",
                "Tem uma probabilidade em percentagem para o utilizador causar 20% de dano através de imunidades, incluindo habilidades.",
                "Есть процентный шанс для пользователя нанести 20% урона через иммунитеты, включая способности.",
                "Tiene una probabilidad en porcentaje para que el usuario cause un daño del 20% a través de inmunidades, incluyendo habilidades."),
            "https://imgur.com/Osldnkc.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: new(
                "User.",
                "Użytkownik.",
                "Usuário.",
                "Utilizador.",
                "Пользователь.",
                "Usuario."),
            worksOn: EPlayerCreatureEffect.PvEAndPvP));

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
            description: new(
                "Gives a percentage chance to drop items.",
                "Zapewnia szansę w procentach na upuszczenie przedmiotów.",
                "Oferece uma chance em porcentagem de dropar itens.",
                "Dá uma probabilidade em percentagem de largar itens.",
                "Дает процентный шанс на выпадение предметов.",
                "Otorga una probabilidad en porcentaje de soltar objetos."),
            "https://imgur.com/7QfJS4w.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: new(
                "Tasked Pokémon.",
                "Przydzielony Pokémon.",
                "Pokémon designado.",
                "Pokémon designado.",
                "Назначенный покемон.",
                "Pokémon asignado."),
            worksOn: EPlayerCreatureEffect.PvEOnly));

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
            description: new(
                "Gives a percentage chance to use 1 random spell of enemy.",
                "Zapewnia szansę w procentach na użycie 1 losowego czaru przeciwnika.",
                "Oferece uma chance em porcentagem de usar 1 feitiço aleatório do inimigo.",
                "Dá uma probabilidade em percentagem de utilizar 1 feitiço aleatório do inimigo.",
                "Дает процентный шанс использовать 1 случайное заклинание врага.",
                "Otorga una probabilidad en porcentaje de usar 1 hechizo aleatorio del enemigo."),
            "https://imgur.com/dMBEkLK.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 60,
            usageInfo: new(
                "User or tasked Pokémon.",
                "Użytkownik lub przydzielony Pokémon.",
                "Usuário ou Pokémon designado.",
                "Utilizador ou Pokémon designado.",
                "Пользователь или назначенный покемон.",
                "Usuario o Pokémon asignado."),
            worksOn: EPlayerCreatureEffect.PvEAndPvP));

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
            description: new(
                "Deals a percentage more damage to the tasked Pokémon.",
                "Zadaje procentowo większe obrażenia przypisanemu Pokémonowi.",
                "Causa um percentual a mais de dano ao Pokémon designado.",
                "Provoca um aumento percentual de dano ao Pokémon designado.",
                "Наносит процентное увеличение урона назначенному Покемону.",
                "Inflige un porcentaje más de daño al Pokémon asignado."),
            "https://imgur.com/66kb6Zc.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: new(
                "Tasked Pokémon.",
                "Przydzielony Pokémon.",
                "Pokémon designado.",
                "Pokémon designado.",
                "Назначенный покемон.",
                "Pokémon asignado."),
            worksOn: EPlayerCreatureEffect.PvEOnly));

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
            description: new(
                "Gives a percentage chance to stun enemy with any spell used by this Pokémon for 2 seconds.",
                "Zapewnia szansę w procentach na odrzucenie wroga dowolnym czarem używanym przez tego Pokemona na 2 sekundy.",
                "Oferece uma chance em porcentagem de atordoar o inimigo com qualquer feitiço usado por este Pokémon por 2 segundos.",
                "Dá uma probabilidade em percentagem de atordoar o inimigo com qualquer feitiço utilizado por este Pokémon durante 2 segundos.",
                "Дает процентный шанс оглушить врага любым заклинанием, использованным этим Покемоном, на 2 секунды.",
                "Otorga una probabilidad en porcentaje de aturdir al enemigo con cualquier hechizo usado por este Pokémon durante 2 segundos."),
            "https://imgur.com/pPIRwKr.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: new(
                "User.",
                "Użytkownik.",
                "Usuário.",
                "Utilizador.",
                "Пользователь.",
                "Usuario."),
            worksOn: EPlayerCreatureEffect.PvEOnly));

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
            description: new(
                "Gives a percentage chance that enemy's stun won't be effective.",
                "Zapewnia szansę w procentach na to, że ogłuszenie przeciwnika nie będzie skuteczne.",
                "Oferece uma chance em porcentagem de que o atordoamento do inimigo não seja efetivo.",
                "Dá uma probabilidade em percentagem de que o atordoamento do inimigo não seja eficaz.",
                "Дает процентный шанс того, что оглушение противника будет неэффективным.",
                "Otorga una probabilidad en porcentaje de que el aturdimiento del enemigo no sea efectivo."),
            "https://imgur.com/of7QjOX.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: new(
                "User or tasked Pokémon. On PvP works only on tasked Pokémon.",
                "Użytkownik lub przydzielony Pokémon. W trybie PvP działa tylko na przydzielonym Pokémonie.",
                "Usuário ou Pokémon designado. No PvP, funciona apenas no Pokémon designado.",
                "Utilizador ou Pokémon designado. No PvP, funciona apenas no Pokémon designado.",
                "Пользователь или назначенный покемон. В PvP работает только на назначенном покемоне.",
                "Usuario o Pokémon asignado. En PvP solo funciona en Pokémon asignado."),
            worksOn: EPlayerCreatureEffect.PvEAndPvP));

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
            description: new(
                "Gives a percentage chance to drop additional loot.",
                "Zapewnia szansę w procentach na upuszczenie dodatkowego łupu.",
                "Oferece uma chance em porcentagem de dropar loot adicional.",
                "Dá uma probabilidade em percentagem de largar loot adicional.",
                "Дает процентный шанс на выпадение дополнительного добычи.",
                "Otorga una probabilidad en porcentaje de soltar botín adicional."),
            "https://imgur.com/IB6A8iI.png",
            pveCooldownInSeconds: 0,
            pvpCooldownInSeconds: 0,
            usageInfo: new(
                "Tasked Pokémon.",
                "Przydzielony Pokémon.",
                "Pokémon designado.",
                "Pokémon designado.",
                "Назначенный покемон.",
                "Pokémon asignado."),
            worksOn: EPlayerCreatureEffect.PvEOnly));
    }
}

namespace PadWiki.WebClient.Entities;

public class Charm : Entity
{
    // Public Constructors
    public Charm(
        string name,
        int firstLevelFirstBoost = 0,
        int firstLevelSecondBoost = 0,
        int firstLeveThirdBoost = 0,
        int secondLevelFirstBoost = 0,
        int secondLevelSecondBoost = 0,
        int secondLeveThirdBoost = 0,
        int thirdLevelFirstBoost = 0,
        int thirdLevelSecondBoost = 0,
        int thirdLeveThirdBoost = 0,
        string description = "",
        string imageUrl = "",
        int pveCooldownInSeconds = 0,
        int pvpCooldownInSeconds = 0,
        string usageInfo = "",
        bool worksInPve = true,
        bool worksInPvp = false)
    {
        FirstLevel = new CharmLevel(firstLevelFirstBoost, firstLevelSecondBoost, firstLeveThirdBoost);
        SecondLevel = new CharmLevel(secondLevelFirstBoost, secondLevelSecondBoost, secondLeveThirdBoost);
        ThirdLevel = new CharmLevel(thirdLevelFirstBoost, thirdLevelSecondBoost, thirdLeveThirdBoost);

        Name = name;
        Description = description;
        ImageUrl = imageUrl;
        PveCooldownInSeconds = pveCooldownInSeconds;
        PvpCooldownInSeconds = pvpCooldownInSeconds;
        UsageInfo = usageInfo;
        WorksInPve = worksInPve;
        WorksInPvp = worksInPvp;
    }

    // Required Parameters
    public CharmLevel FirstLevel { get; private set; }
    public string Name { get; private set; }
    public CharmLevel SecondLevel { get; private set; }
    public CharmLevel ThirdLevel { get; private set; }

    // Optional Parameters
    public string Description { get; private set; }
    public string ImageUrl { get; private set; }
    public int PveCooldownInSeconds { get; private set; }
    public int PvpCooldownInSeconds { get; private set; }
    public string SpoilerImage { get; private set; }
    public string UsageInfo { get; private set; }
    public bool WorksInPve { get; private set; }
    public bool WorksInPvp { get; private set; }
}
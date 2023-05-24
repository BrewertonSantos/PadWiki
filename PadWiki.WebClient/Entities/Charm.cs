using Microsoft.EntityFrameworkCore.Diagnostics;

namespace PadWiki.WebClient.Entities;

public class Charm : Entity
{
    // Public Constructors
    public Charm(
        int firstLevelFirstBoost,
        int firstLevelSecondBoost,
        int firstLeveThirdBoost,
        int SecondLevelFirstBoost,
        int SecondLevelSecondBoost,
        int SecondLeveThirdBoost,
        int ThirdLevelFirstBoost,
        int ThirdLevelSecondBoost,
        int ThirdLeveThirdBoost,
        string name,
        string description = "",
        string imageUrl = "",
        int pveCooldownInSeconds = 0,
        int pvpCooldownInSeconds = 0,
        string usageInfo = "",
        bool worksInPve = true,
        bool worksInPvp = false)
    {
        FirstLevel = new(firstLevelFirstBoost, firstLevelSecondBoost, firstLeveThirdBoost);
        
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
    public CharmLevel FirstLevel { get; set; }
    public string Name { get; private set; }

    // Optional Parameters
    public string Description { get; private set; }
    public string ImageUrl { get; private set; }
    public int PveCooldownInSeconds { get; private set; }
    public int PvpCooldownInSeconds { get; private set; }
    public string UsageInfo { get; private set; }
    public bool WorksInPve { get; private set; }
    public bool WorksInPvp { get; private set; }
}
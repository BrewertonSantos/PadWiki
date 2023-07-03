using PadWiki.WebApp.Enums;
using PadWiki.WebApp.ValueObjects;

namespace PadWiki.WebApp.Entities;

public class Charm : Entity
{
    #region Required Parameters

    public string Name { get; set; }
    public CharmLevel ThirdLevel { get; set; }

    #endregion

    #region Optional Parameters
    
    public ResourceText? Description { get; set; }
    public CharmLevel? FirstLevel { get; set; }
    public string? ImageUrl { get; set; }
    public int? PveCooldownInSeconds { get; set; }
    public int? PvpCooldownInSeconds { get; set; }
    public CharmLevel? SecondLevel { get; set; }
    public string? SpoilerImage { get; set; }
    public ResourceText? UsageInfo { get; set; }
    public EPlayerCreatureEffect WorksOn { get; set; }
    
    #endregion

    #region Public Constructors

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
        ResourceText? description = null,
        string? imageUrl = null,
        int pveCooldownInSeconds = 0,
        int pvpCooldownInSeconds = 0,
        ResourceText? usageInfo = null,
        EPlayerCreatureEffect worksOn = EPlayerCreatureEffect.PvEAndPvP)
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
        WorksOn = worksOn;
    }
    
    #endregion
}
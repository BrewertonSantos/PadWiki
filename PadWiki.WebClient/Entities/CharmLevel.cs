namespace PadWiki.WebClient.Entities;

public class CharmLevel
{
    public CharmLevelUpgrade FirstCharmUpgrade { get; private set; }
    public CharmLevelUpgrade SecondCharmUpgrade { get; private set; }
    public CharmLevelUpgrade ThirdCharmUpgrade { get; private set; }

    public CharmLevel(int firstLevelFirstBoost, int firstLevelSecondBoost, int firstLeveThirdBoost)
    {
    }
}
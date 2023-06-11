namespace PadWiki.WebApp.Entities;

/// <summary>
/// Represents a charm level upgrade
/// </summary>
public class CharmLevelUpgrade
{
    /// <summary>
    /// An integer value to determinate the charm's boost level, 3 represents the maximum value.
    /// </summary>
    public int UpgradeLevel { get; private set; }
    
    /// <summary>
    /// An integer value to determine the charm's boost upgrade value, 100 represents the maximum value.
    /// </summary>
    public int ValueInPercentage { get; private set; }
}
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace PadWiki.WebClient.Entities;

public class Charm : Entity
{
    // Public Constructors
    public Charm(
        string name,
        int taskLevel,
        string boostInfo = "",
        string description = "",
        string imageUrl = "",
        string pvpBehavior = "",
        string usageInfo = "")
    {
        Name = name;
        TaskLevel = taskLevel;
        BoostInfo = boostInfo;
        Description = description;
        ImageUrl = imageUrl;
        PvpBehavior = pvpBehavior;
        UsageInfo = usageInfo;
    }

    // Required Parameters
    public string Name { get; private set; }
    public int TaskLevel { get; private set; }
    
    // Optional Parameters
    public string BoostInfo { get; private set; }
    public string Description { get; private set; }
    public string ImageUrl { get; private set; }
    public string PvpBehavior { get; private set; }
    public string UsageInfo { get; private set; }
}
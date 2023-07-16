using PadWiki.WebApp.Enums;
using PadWiki.WebApp.ValueObjects;

namespace PadWiki.WebApp.Entities;

public class HuntingGround : Entity
{
    public List<Creature> Creatures { get; set; } = null;
    public bool IsDaccOnly { get; set; } = true;
    public ResourceText Description { get; set; } = "There is still not enough information about this quest.";
    public double Difficulty { get; set; } = 50.0;
    public IEnumerable<EEnergy> SuggestedTypesHere { get; set; }
    public double ExperienceRate { get; set; } = 50.0;
    public IEnumerable<string>? TopographyImages { get; set; } = null;
    public string? LocalizationReferenceSlug = null;
    public bool NeedCut { get; set; } = false;
    public bool NeedDive { get; set; } = false;
    public bool NeedFindHole { get; set; } = false;
    public bool NeedRockSmash { get; set; } = false;
    public bool NeedSurf { get; set; } = false;
    public bool NeedTeleport { get; set; } = false;
    public List<Npc>? Npcs { get; set; } = null;
    public double ProfitRate { get; set; } = 50.0;
    public int RequiredLevel { get; set; } = 10;
    public ResourceText Resume { get; set; } = string.Empty;
    public string Slug { get; set; } = null!;
    public string Title { get; set; } = "Unknow HuntingGround";
}
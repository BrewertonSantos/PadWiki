using PadWiki.WebApp.ValueObjects;

namespace PadWiki.WebApp.Entities;

public class Cave : Entity
{
    public ResourceText Title { get; set; } = "Unknow Cave";
    public ResourceText Description { get; set; } = "There is still not enough information about this quest.";
    public ResourceText Resume { get; set; } = string.Empty;
    public string Slug { get; set; } = null!;
}
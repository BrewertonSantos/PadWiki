using PadWiki.WebClient.Entities;

namespace PadWiki.WebClient.ValueObjects;

public abstract class Loot : Entity
{
    public float DropRate { get; set; }
}
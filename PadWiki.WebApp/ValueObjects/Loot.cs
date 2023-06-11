using PadWiki.WebApp.Entities;

namespace PadWiki.WebApp.ValueObjects;

public abstract class Loot : Entity
{
    public float DropRate { get; set; }
}
using PadWiki.WebApp.ValueObjects;

namespace PadWiki.WebApp.Entities;

public sealed class LootItem : Loot
{
    public Item Item { get; init; } = null!;
}
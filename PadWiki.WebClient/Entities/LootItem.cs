using PadWiki.WebClient.ValueObjects;

namespace PadWiki.WebClient.Entities;

public sealed class LootItem : Loot
{
    public Item Item { get; init; } = null!;
}
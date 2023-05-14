using PadWiki.WebClient.ValueObjects;

namespace PadWiki.WebClient.Entities;

public class TradingCardLoot : Loot
{
    public TradingCard TradingCard { get; set; } = null!;
}
using PadWiki.WebApp.ValueObjects;

namespace PadWiki.WebApp.Entities;

public class TradingCardLoot : Loot
{
    public TradingCard TradingCard { get; set; } = null!;
}
using PadWiki.WebApp.ValueObjects;

namespace PadWiki.WebApp.Entities;

public class TechnicalMachineLoot : Loot
{
    public TechnicalMachine TechnicalMachine { get; init; } = null!;
}
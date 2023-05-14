using PadWiki.WebClient.ValueObjects;

namespace PadWiki.WebClient.Entities;

public class TechnicalMachineLoot : Loot
{
    public TechnicalMachine TechnicalMachine { get; init; } = null!;
}
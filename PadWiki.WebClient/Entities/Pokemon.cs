using PadWiki.WebClient.Enums;
using PadWiki.WebClient.ValueObjects;

namespace PadWiki.WebClient.Entities;

/// <summary>
/// Represents the set of characteristics, abilities, elemental types, and other properties of the Pokémon.
/// </summary>
public class Pokemon : Creature
{
    // Required Primitive Type Parameters
    public int Experience { get; private set; } = 10;
    public int ExperiencePerLevel { get; private set; } = 10;
    public int HealthPoints { get; private set; } = 10;
    public int HealthPointsPerLevel { get; private set; } = 10;
    public int PokedexPosition { get; set; } = 0;
    public int Speed { get; private set; } = 0;
    
    // Required Complex Type Parameters
    public ECatchRarity CatchRate { get; private set; } = ECatchRarity.VeryRare;
    
    // Optional Parameters
    
    // Collections
    public List<EEnergy> Immunity { get; private set; } = new();
    public List<Item> Loots { get; private set; } = new();
    public List<EEnergy> Resistance { get; private set; } = new();
    public List<Task> RelatedTasks { get; private set; } = new();
    public List<EEnergy> Type { get; private set; } = new();
    public List<EEnergy> Weakness { get; private set; } = new();
}
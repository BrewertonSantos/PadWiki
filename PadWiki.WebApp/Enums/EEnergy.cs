using System.ComponentModel;

namespace PadWiki.WebApp.Enums;

/// <summary>
/// It represents the elemental energies of the pokemon world.
/// </summary>
public enum EEnergy
{
    [Description("Bug")]
    Bug = 0,
    
    [Description("Dragon")]
    Dragon = 1,
    
    [Description("Electric")]
    Electric = 2,
    
    [Description("Fairy")]
    Fairy = 3,
    
    [Description("Fighting")]
    Fighting = 4,
    
    [Description("Fire")]
    Fire = 5,
    
    [Description("Flying")]
    Flying = 6,
    
    [Description("Ghost")]
    Ghost = 7,
    
    [Description("Grass")]
    Grass = 8,
    
    [Description("Ground")]
    Ground = 9,
    
    [Description("Ice")]
    Ice = 10,
    
    [Description("Normal")]
    Normal = 11,
    
    [Description("Poison")]
    Poison = 12,
    
    [Description("Psychic")]
    Psychic = 13,
    
    [Description("Rock")]
    Rock = 14,
    
    [Description("Steel")]
    Steel = 15,
    
    [Description("Water")]
    Water = 16
}

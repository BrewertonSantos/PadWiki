using System.ComponentModel;

namespace PadWiki.WebApp.Enums;

/// <summary>
/// It represents the elemental energies of the pokemon world.
/// </summary>
public enum EEnergy
{
    [Description("Bug")]
    Bug = 0,
    
    [Description("Dark")]
    Dark = 1,
    
    [Description("Dragon")]
    Dragon = 2,
    
    [Description("Electric")]
    Electric = 3,
    
    [Description("Fairy")]
    Fairy = 4,
    
    [Description("Fighting")]
    Fighting = 5,
    
    [Description("Fire")]
    Fire = 6,
    
    [Description("Flying")]
    Flying = 7,
    
    [Description("Ghost")]
    Ghost = 8,
    
    [Description("Grass")]
    Grass = 9,
    
    [Description("Ground")]
    Ground = 10,
    
    [Description("Ice")]
    Ice = 112,
    
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
using PadWiki.WebClient.Enums;

namespace PadWiki.WebClient.Entities;

/// <summary>
/// represents the implementation of a collectible card that portrays creatures, items, and characters from the Pokémon world.
/// </summary>
public class TradingCard : Entity
{
    // Public Constructors
    public TradingCard(
        int index,
        string imagePath,
        string title,
        ECardRarity cardRarity = ECardRarity.Unavailable,
        string description = "Unknown",
        EDropRarity dropRarity = EDropRarity.Unavailable,
        int requiredLevel = 10)
    {
        Index = index;
        ImagePath = imagePath;
        Title = title;

        CardRarity = cardRarity;
        Description = description;
        DropRarity = dropRarity;
        RequiredLevel = requiredLevel;
    }
    
    // Required Parameters
    public int Index { get; set; }
    public string ImagePath { get; set; } = null!;
    public string Title { get; set; } = null!;

    // Optional Parameters
    public ECardRarity CardRarity { get; set; } = ECardRarity.Unavailable;
    public string Description { get; private set; } = "Unknown";
    public EDropRarity DropRarity { get; set; } = EDropRarity.Unavailable;
    public int RequiredLevel { get; set; } = 10;

    // Collections
    public IEnumerable<ESkill> RequiredSkills { get; set; } = new List<ESkill>();
}
using PadWiki.WebClient.Enums;

namespace PadWiki.WebClient.Entities;

public class PokemonCard : Entity
{
    // Required Parameters
    public int Index { get; set; }
    public string ImagePath { get; set; } = null!;
    public string Title { get; set; } = null!;

    // Optional Parameters
    public ECardRarity CardRarity { get; set; } = ECardRarity.Unavailable;
    public string Description { get; set; } = "Unknown";
    public EDropRarity DropRarity { get; set; } = EDropRarity.Unavailable;
    public int RequiredLevel { get; set; } = 10;

    // Collections
    public IEnumerable<ESkill> RequiredSkills { get; set; } = new List<ESkill>();

    public PokemonCard(
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
}
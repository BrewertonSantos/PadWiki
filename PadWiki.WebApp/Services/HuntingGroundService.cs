using PadWiki.WebApp.Entities;
using PadWiki.WebApp.Enums;
using PadWiki.WebApp.Services.Contracts;

namespace PadWiki.WebApp.Services;

public class HuntingGroundService : IHuntingGroundService
{
    public List<HuntingGround> HuntingGrounds { get; set; }
    
    public HuntingGroundService()
    {
        HuntingGrounds = new();
        PopulateCaves();
    }

    public HuntingGround? GetBySlug(string slug)
        => HuntingGrounds.FirstOrDefault(cave => cave.Slug == slug);

    public void PopulateCaves()
    {
        HuntingGrounds.Add(new HuntingGround
        {
            Id = new Guid("40a37d7e-0215-4624-92d3-43f9063f527d"),
            Title = "PAPOI's Psychic Hideout",
            Resume = new(
                "",
                "",
                "",
                "",
                "",
                ""),
            Slug = "mind-sanctuary",
            Description = "",
            Difficulty = 50.80,
            ExperienceRate = 73.40,
            ProfitRate = 60.13,
            RequiredLevel = 190,
            TopographyImages = new []
            {
                "294d76b7-396c-46e9-bfa6-90dde17df5ba.png",
                "0a11ad10-d09c-4787-92da-6b7f795b73f6;png",
                "b9eb4323-c615-4230-a2c6-1d90e3316d31.png"
            },
            SuggestedTypesHere = new []
            {
                EEnergy.Bug,
                EEnergy.Flying,
                EEnergy.Dark
            }
        });
    }
}
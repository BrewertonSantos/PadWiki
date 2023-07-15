using PadWiki.WebApp.Entities;
using PadWiki.WebApp.Services.Contracts;

namespace PadWiki.WebApp.Services;

public class CaveService : ICaveService
{
    public List<Cave> Caves { get; set; }
    
    public CaveService()
    {
        Caves = new();
        PopulateCaves();
    }

    public Cave? GetBySlug(string slug)
        => Caves.FirstOrDefault(cave => cave.Slug == slug);

    public void PopulateCaves()
    {
        Caves.Add(new Cave()
        {
            Id = new Guid("40a37d7e-0215-4624-92d3-43f9063f527d"),
            Title = new(
                "PAPOI's Psychic Hideout",
                "Tajemnicze kryjówka PAPOI",
                "Esconderijo Psíquico da PAPOI",
                "Esconderijo Psíquico da PAPOI",
                "Психическое убежище PAPOI",
                "Escondite Psíquico de PAPOI"),
            Resume = new(
                "",
                "",
                "",
                "",
                "",
                ""),
            Slug = "papoi-psychic-hideout"
        });
    }
}
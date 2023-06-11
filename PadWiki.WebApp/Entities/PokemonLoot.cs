using PadWiki.WebApp.Enums;

namespace PadWiki.WebApp.Entities;

sealed class PokemonLoot
{
    public Item Item { get; set; } = null!;
    public float DropRate { get; set; } = 0.2f;
    public EDropRarity DropRarity { get; set; } = EDropRarity.VeryRare;
    
    /// <summary>
    /// 
    /// </summary>
    public int? DropRange { get; set; } = null;
}
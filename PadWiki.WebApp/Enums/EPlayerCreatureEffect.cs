using System.ComponentModel;
using PadWiki.WebApp.Resources;

namespace PadWiki.WebApp.Enums;

public enum EPlayerCreatureEffect
{
    [Description(nameof(EnumResources.PvEAndPvP))]
    PvEAndPvP = 0,
    
    [Description(nameof(EnumResources.PvEOnly))]
    PvEOnly = 1,
    
    [Description(nameof(EnumResources.PvPOnly))]
    PvPOnly = 2
}
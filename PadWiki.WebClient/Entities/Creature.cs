using System.Runtime.InteropServices;

namespace PadWiki.WebClient.Entities;

public class Creature : Entity
{
    public string Name { get; private set; } = "Unown";
    public string Description { get; private set; } = string.Empty;
}
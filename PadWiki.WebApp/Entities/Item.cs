namespace PadWiki.WebApp.Entities;

public class Item : Entity
{
    public string Tittle { get; private set; } = "unknown item";
    public string Description { get; private set; } = string.Empty;
    public bool Consumable { get; private set; } = false;
}
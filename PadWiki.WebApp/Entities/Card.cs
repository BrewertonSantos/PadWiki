using PadWiki.WebApp.ValueObjects;

namespace PadWiki.WebApp.Entities;

public class Card : Entity
{
    public string CallbackUrl { get; private set; }
    public DateTime CreateDate { get; private set; }
    public ResourceText Description { get; private set; }
    public DateTime EndDate { get; private set; }
    public ResourceText Tittle { get; private set; }
    public string BackgroundImage { get; private set; }
    
    public Card(string callbackUrl, DateTime createDate, DateTime endDate, ResourceText description, ResourceText tittle, string backgroundImage)
        => (CallbackUrl, CreateDate, EndDate, Description, Tittle, BackgroundImage)
            =  (callbackUrl, createDate, endDate, description, tittle, backgroundImage);

    // Computed Properties
    public bool IsActive() => EndDate.Date < DateTime.UtcNow.Date;
}
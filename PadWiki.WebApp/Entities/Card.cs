namespace PadWiki.WebApp.Entities;

public class Card : Entity
{
    public Card(string callbackUrl, DateTime createDate, DateTime endDate, string description, string tittle, string backgroundImage)
        => (CallbackUrl, CreateDate, EndDate, Description, Tittle, BackgroundImage)
            = (callbackUrl, createDate, endDate, description, tittle, backgroundImage);

    public string CallbackUrl { get; private set; }
    public DateTime CreateDate { get; private set; }
    public string Description { get; private set; }
    public DateTime EndDate { get; private set; }
    public string Tittle { get; private set; }
    public string BackgroundImage { get; private set; }

    // Computed Properties
    public bool IsActive() => EndDate.Date < DateTime.UtcNow.Date;
}
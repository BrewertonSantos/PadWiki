namespace PadWiki.WebApp.Entities;

public class Role : Entity<Guid>
{
    public string Title { get; set; }
    public IEnumerable<Claim> Claims { get; set; }
}
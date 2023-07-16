namespace PadWiki.WebApp.Entities;

public class User : Entity<Guid>
{
    public string Name { get; set; }
    public IEnumerable<Role>? Roles { get; set; }
}
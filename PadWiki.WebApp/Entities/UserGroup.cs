namespace PadWiki.WebApp.Entities;

public class UserGroup : Entity<int>
{
    public string Name { get; set; }
    public List<User> Users { get; set; }
}
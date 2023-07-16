using PadWiki.WebApp.Enums;

namespace PadWiki.WebApp.Entities;

public abstract class Entity<T> where T : new()
{
    public T Id { get; set; }
    public ECategory Category { get; set; } = ECategory.Undefined;

    protected Entity() => Id = new T();
    protected Entity(T id) => Id = id;
}

public abstract class Entity : Entity<Guid>
{
    protected Entity() => Id = Guid.NewGuid();
}
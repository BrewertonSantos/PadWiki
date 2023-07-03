using Microsoft.EntityFrameworkCore;
using PadWiki.WebClient.Data.Mappings;

namespace PadWiki.WebClient.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TradingCardMap());
    }
}
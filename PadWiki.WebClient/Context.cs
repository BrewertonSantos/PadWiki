using Microsoft.EntityFrameworkCore;
using PadWiki.WebClient.Data;

namespace PadWiki.WebClient;

public static class Context
{
    public static void ConfigureDataContext(IServiceCollection services)
    {
        services.AddDbContext<DataContext>(
            x =>
            {
                x.UseInMemoryDatabase("padwiki-db");
            });
    }

    public static void ConfigureServices(IServiceCollection services)
    {
    }
}
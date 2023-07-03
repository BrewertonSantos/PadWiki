using Microsoft.AspNetCore.Http;

namespace PadWiki.WebApp.Middlewares;

public class CacheControlMiddleware
{
    private readonly RequestDelegate _next;
    private readonly Uri _baseAddress;

    public CacheControlMiddleware(RequestDelegate next, Uri baseAddress) => (_next, _baseAddress) = (next, baseAddress);

    public async Task Invoke(HttpContext context)
    {
        await _next(context);

        if (context.Response.ContentType?.StartsWith("image/") ?? false)
        {
            context.Response.Headers.Append("Cache-Control", "public, max-age=3600");
            context.Response.Headers.Append("Expires", DateTime.UtcNow.AddHours(2).ToString("R"));
        }
    }
}
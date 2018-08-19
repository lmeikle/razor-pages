using Microsoft.AspNetCore.Builder;
using razor_pages;

public static class BuilderExtensions
{
    public static IApplicationBuilder UseElapsedTimeMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ElapsedTimeMiddleware>();
    }
}
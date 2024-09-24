namespace OneReview.RequestPipeline;

using Microsoft.AspNetCore.Diagnostics;
using OneReview.Persistence.Database;

public static class WebApplicationExtensions
{
    public static WebApplication InitializeDatabase(this WebApplication app)
    {
        DbInitializer.Initialize(app.Configuration[DbConstants.DefaultConnectionPath]);

        return app;
    }

    public static WebApplication UseGlobalErrorHandling(this WebApplication app)
    {
        app.UseExceptionHandler("/error");

        app.Map("/error", (HttpContext httpContext) =>
        {
            var exception = httpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

            return Results.Problem();
        });

        return app;
    }
}

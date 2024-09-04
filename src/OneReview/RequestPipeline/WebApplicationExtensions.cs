namespace OneReview.RequestPipeline;

using OneReview.Persistence.Database;

public static class WebApplicationExtensions
{
    public static WebApplication InitializeDatabase(this WebApplication app)
    {
        DbInitializer.Initialize(app.Configuration[DbConstants.DefaultConnectionPath]);

        return app;
    }
}

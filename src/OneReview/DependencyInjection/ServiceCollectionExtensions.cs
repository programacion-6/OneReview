namespace OneReview.DependencyInjection;

using OneReview.Persistence.Database;
using OneReview.Persistence.Repositories;
using OneReview.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ProductsService>();

        return services;
    }

    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ProductsRepository>();
        services.AddScoped<IDbConnectionFactory>(_ => 
            new NpgsqlConnectionFactory(configuration[DbConstants.DefaultConnectionPath]));

        return services;
    }

    public static IServiceCollection AddGlobalErrorHandling(this IServiceCollection services)
    {
        services.AddProblemDetails(options =>
        {
            options.CustomizeProblemDetails = context =>
            {
                context.ProblemDetails.Extensions["traceId"] = context.HttpContext.TraceIdentifier;
                context.ProblemDetails.Extensions["serviceVersion"] = "0.0.1";
                context.ProblemDetails.Extensions["exception"] = "";
            };
        });

        return services;
    }
}

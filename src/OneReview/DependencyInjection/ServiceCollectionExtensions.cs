namespace OneReview.DependencyInjection;

using OneReview.Persistence.Database;
using OneReview.Persistence.Repositories;
using OneReview.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ProductsService>();
        services.AddScoped<IMapperFromDomain<Product, ProductResponse>, ProductResponse>();

        return services;
    }

    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ProductsRepository>();
        services.AddScoped<IDbConnectionFactory>(_ => 
            new NpgsqlConnectionFactory(configuration[DbConstants.DefaultConnectionPath]));

        return services;
    }
}

namespace OneReview.DependencyInjection;

using OneReview.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ProductsService>();

        return services;
    }
}

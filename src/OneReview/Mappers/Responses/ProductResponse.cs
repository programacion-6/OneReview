namespace OneReview.Mappers.Responses;

using OneReview.Domain;

public record ProductResponse(
        Guid Id,
        string Name,
        string Description,
        string Category,
        string SubCategory) : IResponse<Product>
{
    public static Product FromDomain(Product product)
    {
        return new Product
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Category = product.Category,
            SubCategory = product.SubCategory
        };
    }
}

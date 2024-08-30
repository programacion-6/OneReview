namespace OneReview.Mappers.Responses;

using OneReview.Domain;

public record ProductResponse(
        Guid Id,
        string Name,
        string Description,
        string Category,
        string SubCategory)
{
    public static ProductResponse FromDomain(Product product)
    {
        return new ProductResponse
        (
            product.Id,
            product.Name,
            product.Description,
            product.Category,
            product.SubCategory
        );
    }
}

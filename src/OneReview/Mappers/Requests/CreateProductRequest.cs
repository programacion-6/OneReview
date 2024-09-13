namespace OneReview.Mappers.Requests;

using OneReview.Domain;

public record CreateProductRequest(
        string Name,
        string Description,
        string Category,
        string SubCategory) : IRequest<Product>
{
    public Product ToDomain()
    {
        return new Product
        {
            Name = Name,
            Description = Description,
            Category = Category,
            SubCategory = SubCategory
        };
    }
}

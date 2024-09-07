namespace OneReview.Services;

public class ProductValidator : IValidator<Product>
{
    public bool Validate(Product product)
    {
        if (string.IsNullOrWhiteSpace(product.Name) ||
            string.IsNullOrWhiteSpace(product.Description) ||
            string.IsNullOrWhiteSpace(product.Category) ||
            string.IsNullOrWhiteSpace(product.SubCategory))
        {
            return false;
        }

        return true;
    }
}

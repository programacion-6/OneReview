using OneReview.Domain;

namespace OneReview.Services;

public class ProductsServiceSearcher
{
    public Product? Search(string query)
    {
        foreach (Product product in ProductsService.ProductsRepository)
        {
            if (product.Name.Contains(query, StringComparison.CurrentCultureIgnoreCase))
            {
                return product;
            }
        }

        return null;
    }
}

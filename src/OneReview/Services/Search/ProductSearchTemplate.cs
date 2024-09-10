using OneReview.Domain;

namespace OneReview.Services.Search;

public abstract class ProductSearchTemplate
{
    public List<Product> Search()
    {
        var products = GetAllProducts();
        products = ApplyFilters(products);
        return products;
    }

    protected abstract List<Product> ApplyFilters(List<Product> products);

    private List<Product> GetAllProducts()
    {
        return [];
    }
}


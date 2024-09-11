namespace OneReview.Services;

using OneReview.Domain;

public class ProductsService
{
    private readonly List<Product> _products ;

    public ProductsService()
    {
        _products = [];
    }

    public void Create(Product product)
    {
        if (!ExistsProduct(product))
        {
            _products.Add(product);
        }
        else
        {
            Console.Error.WriteLine($"Product already exists: {product.Name}");
        }
    }

    public Product Get(Guid id)
    {
        return _products.FirstOrDefault(product => product.Id == id);
    }

    private bool ExistsProduct(Product product)
    {
        return _products.Contains(product);
    }
}

namespace OneReview.Services;

using OneReview.Domain;

public class ProductsService
{
    protected internal static readonly List<Product> ProductsRepository = [];

    public void Create(Product product)
    {
        if (!ExistsProduct(product))
        {
            ProductsRepository.Add(product);
        }
        else
        {
            Console.Error.WriteLine($"Product already exists: {product.Name}");
        }
    }

    public Product Get(Guid id)
    {
        return ProductsRepository.FirstOrDefault(product => product.Id == id);
    }

    private bool ExistsProduct(Product product)
    {
        return ProductsRepository.Contains(product);
    }
}

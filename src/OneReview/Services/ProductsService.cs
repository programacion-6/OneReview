using OneReview.Domain;

namespace OneReview.Services;

public class ProductsService
{
    private static readonly List<Product> ProductsRepository = [];

    public void Create(Product product)
    {
        ProductsRepository.Add(product);
    }

    public Product Get(Guid id)
    {
        return ProductsRepository.FirstOrDefault(product => product.Id == id);
    }
}

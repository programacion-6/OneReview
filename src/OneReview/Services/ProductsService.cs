namespace OneReview.Services;

using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;
using OneReview.Persistence.Repositories;

public class ProductsService
{
    private readonly ProductsRepository _productsRepository;

    public ProductsService(ProductsRepository productsRepository)
    {
        _productsRepository = productsRepository;
    }

    public async Task<ProductResponse> CreateProductAsync(CreateProductRequest request)
    {
        var product = request.ToDomain();

        await _productsRepository.CreateAsync(product);

        return ProductResponse.FromDomain(product);
    }

    public async Task<ProductResponse> GetProductByIdAsync(Guid productId)
    {
        var product = await _productsRepository.GetByIdAsync(productId);
        return product is null ? null : ProductResponse.FromDomain(product);
    }
}

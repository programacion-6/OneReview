using OneReview.Domain;
using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;
using OneReview.Services;

namespace OneReview.Controllers;

public class ProductsController : BaseController<Product, CreateProductRequest, ProductResponse>
{
    private readonly ProductsService _productsService;

    public ProductsController(ProductsService productsService)
    {
        _productsService = productsService;
    }

    protected override async Task<Product> CreateEntityAsync(CreateProductRequest request)
    {
        var product = request.ToDomain();
        await _productsService.CreateAsync(product);
        return product;
    }

    protected override async Task<Product> GetEntityAsync(Guid id)
    {
        return await _productsService.GetAsync(id);
    }
}

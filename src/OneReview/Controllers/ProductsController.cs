namespace OneReview.Controllers;

public class ProductsController : ControllerWrapper<Product, ProductResponse, CreateProductRequest>
{
    private readonly ProductsService _productsService;

    public ProductsController(ProductsService productsService, IMapperFromDomain<Product, ProductResponse> mapperFromDomain)
        : base(mapperFromDomain)
    {
        _productsService = productsService;
    }

    protected override async Task<Product> CreateEntity(CreateProductRequest request)
    {
        var product = request.ToDomain();
        await _productsService.CreateAsync(product);

        return product;
    }

    protected override async Task<Product> GetEntity(Guid productId)
    {
        return await _productsService.GetAsync(productId);
    }
}

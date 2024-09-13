using Microsoft.AspNetCore.Mvc;

using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;
using OneReview.Services;

namespace OneReview.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly MainController _mainController;
    private readonly ProductsService _productsService;

    public ProductsController(ProductsService productsService, MainController mainController)
    {
        _productsService = productsService;
        _mainController = mainController;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request)
    {
        // mapping to internal representation
        var product = request.ToDomain();

        // invoking the use case
        await _productsService.CreateAsync(product);

        // mapping to external representation
        var response = ProductResponse.FromDomain(product);

        return _mainController.CreatedResponse(
            nameof(Get), 
            product.Id, 
            response
        );
    }

    [HttpGet("{productId:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid productId)
    {
        // get the product
        var product = await _productsService.GetAsync(productId);

        return product is null
            ? _mainController.NotFoundProblem(productId, "Product")
            : Ok(ProductResponse.FromDomain(product));
    }
}

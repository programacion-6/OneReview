namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;
using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;
using OneReview.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductsController(ProductsService productsService) : ControllerBase
{
    private readonly ProductsService _productsService = productsService;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request)
    {
        // mapping to internal representation
        var product = request.ToDomain();

        // invoking the use case
        await _productsService.CreateAsync(product);

        // mapping to external representation
        var response = ProductResponse.FromDomain(product);

        return CreatedAtAction(
            actionName: nameof(Get),
            routeValues: new { ProductId = product.Id },
            value: response
        );
    }

    [HttpGet("{productId:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid productId)
    {
        // get the product
        var product = await _productsService.GetAsync(productId);

        return product is null
            ? Problem(statusCode: StatusCodes.Status404NotFound, detail: $"Product not found (productId {productId})")
            : Ok(ProductResponse.FromDomain(product));
    }
}

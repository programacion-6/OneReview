namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;
using OneReview.Mappers.Requests;
using OneReview.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ProductsService _productsService;

    public ProductsController(ProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request)
    {
        var response = await _productsService.CreateProductAsync(request);
        return CreatedAtAction(nameof(Get), new { ProductId = response.Id }, response);
    }

    [HttpGet("{productId:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid productId)
    {
        var response = await _productsService.GetProductByIdAsync(productId);

        return response is null
            ? Problem(statusCode: StatusCodes.Status404NotFound, detail: $"Product not found (productId {productId})")
            : Ok(response);
    }
}

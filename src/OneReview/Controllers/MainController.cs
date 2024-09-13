namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;
using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;
using OneReview.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class MainController : ControllerBase
{
    private readonly ProductsService _productsService;

    public MainController(ProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpPost("products")]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
    {
        var response = await _productsService.CreateProductAsync(request);

        return CreatedAtAction(nameof(GetProduct), new { ProductId = response.Id }, response);
    }

    [HttpGet("products/{productId:guid}")]
    public async Task<IActionResult> GetProduct([FromRoute] Guid productId)
    {
        var response = await _productsService.GetProductByIdAsync(productId);

        return response is null
            ? Problem(statusCode: StatusCodes.Status404NotFound, detail: $"Product not found (productId {productId})")
            : Ok(response);
    }
}

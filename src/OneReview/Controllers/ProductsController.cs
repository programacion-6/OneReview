namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;
using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;
using OneReview.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductsController : BaseConstroller
{
    private readonly ProductsService _productsService;

    public ProductsController(ProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request)
    {
        var validationResult = ValidateRequest(request);
        if (validationResult != null) return validationResult;

        var product = request.ToDomain();
        await _productsService.CreateAsync(product);

        return CreatedAtAction(nameof(Get), new { ProductId = product.Id }, ProductResponse.FromDomain(product));
    }

    [HttpGet("{productId:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid productId)
    {
        var product = await _productsService.GetAsync(productId);

        return product is null
            ? HandleNotFound($"Product not found (productId {productId})")
            : Ok(ProductResponse.FromDomain(product));
    }
}

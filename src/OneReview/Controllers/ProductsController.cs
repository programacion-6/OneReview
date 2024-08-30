namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;
using OneReview.Domain;
using OneReview.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductsController(ProductsService productsService) : ControllerBase
{
    private readonly ProductsService _productsService = productsService;

    [HttpPost]
    public IActionResult Create([FromBody] CreateProductRequest request)
    {
        // mapping to internal representation
        var product = request.ToDomain();

        // invoking the use case
        _productsService.Create(product);

        // mapping to external representation
        var response = ProductResponse.FromDomain(product);

        return CreatedAtAction(
            actionName: nameof(Get),
            routeValues: new { ProductId = product.Id },
            value: response
        );
    }

    [HttpGet("{productId:guid}")]
    public IActionResult Get([FromRoute] Guid productId)
    {
        // get the product
        var product = _productsService.Get(productId);

        // return 200 ok response
        return product is null 
            ? Problem(statusCode: StatusCodes.Status404NotFound, detail: $"Product not found (productId {productId})")
            : Ok(ProductResponse.FromDomain(product));
    }
    
    public record CreateProductRequest(
        string Name,
        string Description,
        string Category,
        string SubCategory)
    {
        public Product ToDomain()
        {
            return new Product
            {
                Name = Name,
                Description = Description,
                Category = Category,
                SubCategory = SubCategory
            };
        }
    }

    public record ProductResponse(
        Guid Id,
        string Name,
        string Description,
        string Category,
        string SubCategory)
    {
        public static ProductResponse FromDomain(Product product)
        {
            return new ProductResponse
            (
                product.Id,
                product.Name,
                product.Description,
                product.Category,
                product.SubCategory
            );
        }
    }
}

namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;

using OneReview.Domain;

using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;
using OneReview.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductsController(ProductsService productsService) 
    : MainController<CreateProductRequest, ProductResponse, Product>
{
    private readonly ProductsService _productsService = productsService;

    protected override async Task CreateAsync(Product product)
    {
        await _productsService.CreateAsync(product);
    }

    protected override async Task<Product> GetAsync(Guid id)
    {
        return await _productsService.GetAsync(id);
    }
}

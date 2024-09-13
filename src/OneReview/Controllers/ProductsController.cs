using Microsoft.AspNetCore.Mvc;
using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;
using OneReview.Domain;
using OneReview.Services;

namespace OneReview.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductsController(ProductsService productsService) 
    : MainController<CreateProductRequest, ProductResponse, Product>
{
    private readonly ProductsService _productsService = productsService;

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

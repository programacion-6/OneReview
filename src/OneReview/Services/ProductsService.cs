namespace OneReview.Services;

using OneReview.Domain;
using OneReview.Helpers;
using OneReview.Mappers.Responses;
using OneReview.Models;
using OneReview.Persistence.Repositories;
using OneReview.Validators;

public class ProductsService(ProductsRepository productsRepository) : IService<Product, ProductResponse>
{
    private readonly ProductsRepository _productsRepository = productsRepository;

    public async Task<ServiceResult<ProductResponse>> CreateAsync(Product product)
    {
        var validator = new ProductsValidator();
        var validationResult = validator.Validate(product);
        var response = new ServiceResult<ProductResponse> { Success = validationResult.IsValid };

        if (validationResult.IsValid)
        {
            var productResponse = await _productsRepository.CreateAsync(product);
            response.Data = ProductResponse.FromDomain(productResponse);
        }
        else
        {
            response.Errors = validationResult.Errors.Select(x => x.ToValidationResponse()).ToArray();
        }

        return response;
    }

    public async Task<ServiceResult<ProductResponse>> GetByIdAsync(Guid productId)
    {
        var product = await _productsRepository.GetByIdAsync(productId);

        return new ServiceResult<ProductResponse> 
        { 
            Data = ProductResponse.FromDomain(product)
        };
    }
}

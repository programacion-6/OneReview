namespace OneReview.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OneReview.Services;

    [ApiController]
    [Route("api/v1/[controller]")]
    public class MainController : ControllerBase
    {
        private readonly ProductsController _productsController;

        public MainController(ProductsService productsService)
        {
            _productsController = new ProductsController(productsService);
        }
        [HttpPost("products")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            return await _productsController.Create(request);
        }

        [HttpGet("products/{productId:guid}")]
        public async Task<IActionResult> GetProduct([FromRoute] Guid productId)
        {
            return await _productsController.Get(productId);
        }
    }
}

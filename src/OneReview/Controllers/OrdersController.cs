namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;
using OneReview.Services;
using OneReview.Mappers.Requests;

[ApiController]
[Route("api/v1/[controller]")]
public class OrdersController(OrderService orderService) : ControllerBase
{
    private readonly OrderService _orderService = orderService;

    [HttpPost("process")]
    public IActionResult ProcessOrder([FromBody] ProcessOrderRequest request)
    {
        // Invoke the service to process the order
        _orderService.ProcessOrder(request.ToDomain().TotalAmount);

        // Return 200 OK response
        return Ok(new { Message = "Order processed successfully" });
    }
}

namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;
using OneReview.OverServices;
using OneReview.OverServices.Discounts;

[ApiController]
[Route("api/v1/[controller]")]
public class OrdersController(OrderService orderService) : ControllerBase
{
    private readonly OrderService _orderService = orderService;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="totalAmount">This should be a model.</param>
    /// <param name="discountType">You should parse this</param>
    /// <returns></returns>
    [HttpPost("paypal")]
    public IActionResult ProcessOrderPaypal([FromBody] decimal totalAmount, [FromQuery] DiscountType discountType)
    {
        _orderService.ProcessOrder(totalAmount, discountType, PaymentMethod.Paypal);

        return Ok("Order processed successfully.");
    }

    [HttpPost("stripe")]
    public IActionResult ProcessOrderStripe([FromBody] decimal totalAmount, [FromQuery] DiscountType discountType)
    {
        _orderService.ProcessOrder(totalAmount, discountType, PaymentMethod.Stripe);

        return Ok("Order processed successfully.");
    }
}

using OneReview.OverServices.Discounts;

namespace OneReview.OverServices;

public class PayPalPaymentService : IPaymentService
{
    private readonly IDiscountService _discountService;

    public PayPalPaymentService(IDiscountService discountService)
    {
        _discountService = discountService;
    }

    public void ProcessPayment(decimal amount, DiscountType discountType)
    {
        var discountAmount = _discountService.ApplyDiscount(amount, discountType);
        Console.WriteLine($"Processing {discountAmount} through PayPal");
    }
    
}

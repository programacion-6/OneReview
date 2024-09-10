using OneReview.OverServices.Discounts;

namespace OneReview.OverServices;

public class StripePaymentService : IPaymentService
{
    private readonly IDiscountService _discountService;

    public StripePaymentService(IDiscountService discountService)
    {
        _discountService = discountService;
    }

    public void ProcessPayment(decimal amount, DiscountType discountType)
    {
        var discountAmount = _discountService.ApplyDiscount(amount, discountType);
        Console.WriteLine($"Processing {discountAmount} through Stripe");
    }
}

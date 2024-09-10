using OneReview.OverServices.Discounts;

namespace OneReview.OverServices;

public class PayPalPaymentService : IPaymentService
{
    private readonly IDiscountStrategy _discountStrategy;

    public PayPalPaymentService(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        var discountAmount = _discountStrategy.ApplyDiscount(amount);
        Console.WriteLine($"Processing {discountAmount} through PayPal");
    }
}

using OneReview.OverServices.Discounts;

namespace OneReview.OverServices;

public class StripePaymentService : IPaymentService
{
    public void ProcessPayment(decimal amount, DiscountType discountType)
    {
        IDiscountStrategy discountStrategy = DiscountStrategyFactory.CreateDiscountStrategy(discountType);
        var discountAmount = discountStrategy.ApplyDiscount(amount);

        Console.WriteLine($"Processing {discountAmount} through Paypal with {discountType} discount type");
    }
}

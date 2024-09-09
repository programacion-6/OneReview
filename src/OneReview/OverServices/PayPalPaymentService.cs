using OneReview.OverServices.Discounts;

namespace OneReview.OverServices;

public class PayPalPaymentService : IPaymentService
{
    public void ProcessPayment(decimal amount, DiscountType discountType)
    {
        IDiscountStrategy discountStrategy = DiscountStrategyFactory.CreateDiscountStrategy(discountType);
        var discountAmount = discountStrategy.ApplyDiscount(amount);

        // Overly complex payment logic
        Console.WriteLine($"Processing {discountAmount} through Paypal with {discountType} discount type");
    }
}

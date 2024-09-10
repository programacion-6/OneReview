namespace OneReview.OverServices;

using OneReview.OverServices.Discounts;

public class OrderService
{
    // Apply discount
    // Process payment
    public void ProcessOrder(decimal totalAmount, DiscountType discountType, PaymentMethod paymentMethod)
    {
        var discountAmount = ApplyDiscount(totalAmount, discountType);
        ProcessPayment(discountAmount, paymentMethod);
    }

    private static decimal ApplyDiscount(decimal totalAmount, DiscountType discountType)
    {
        var discountStrategy = DiscountStrategyFactory.CreateDiscountStrategy(discountType);

        return discountStrategy.ApplyDiscount(totalAmount);
    }
    
    private static void ProcessPayment(decimal discountAmount, PaymentMethod paymentMethod)
    {
        var paymentService = PaymentServiceFactory.CreatePaymentService(paymentMethod);
        paymentService.ProcessPayment(discountAmount);
    }
}

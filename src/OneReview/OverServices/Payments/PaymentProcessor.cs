using OneReview.OverServices.Discounts;

namespace OneReview.OverServices.Payments;

public class PaymentProcessor
{
    private readonly IPaymentService _paymentService;
    private readonly IDiscountStrategy _discountStrategy;
    public PaymentProcessor(IPaymentService paymentService, IDiscountStrategy discountStrategy)
    {
        _paymentService = paymentService;
        _discountStrategy = discountStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        var discountedAmount = _discountStrategy.ApplyDiscount(amount);
        _paymentService.ProcessPayment(discountedAmount);
    }
}

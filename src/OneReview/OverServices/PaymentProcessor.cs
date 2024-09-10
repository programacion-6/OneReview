using OneReview.OverServices.DiscountsStrategy;

namespace OneReview.OverServices;

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
        // Apply Discount
        amount = _discountStrategy.ApplyDiscount(amount);

        // Proccess payment 
        _paymentService.ProcessPayment(amount);
    }
}

using OneReview.OverServices.Discounts;

namespace OneReview.OverServices;

public class PaymentService
{
    private readonly IPaymentService _paymentService;
    private readonly IDiscountStrategy _discountStrategy;

    public PaymentService(IPaymentService paymentService, IDiscountStrategy discountStrategy)
    {
        _paymentService = paymentService;
        _discountStrategy = discountStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        amount = _discountStrategy.ApplyDiscount(amount);

        _paymentService.ProcessPayment(amount);
    }
}

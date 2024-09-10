namespace OneReview.OverServices;

public class OrderService(IDiscountStrategy discountStrategy, IPaymentService paymentService)
{
    private readonly IDiscountStrategy _discountStrategy = discountStrategy;
    private readonly IPaymentService _paymentService = paymentService;

    public void ProcessOrder(decimal totalAmount)
    {
        totalAmount = _discountStrategy.ApplyDiscount(totalAmount);
        _paymentService.ProcessPayment(totalAmount);
    }

}

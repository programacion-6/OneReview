using OneReview.OverServices.Discounts;

namespace OneReview.OverServices;

public class PayOrderService(IDiscountStrategy discountStrategy, IPaymentService paymentService)
{
    private readonly IDiscountStrategy _discountStrategy = discountStrategy;
    private readonly IPaymentService _paymentService = paymentService;

    public void PayOrder(decimal totalAmount){
        totalAmount = _discountStrategy.ApplyDiscount(totalAmount);
        _paymentService.ProcessPayment(totalAmount);
    }

}

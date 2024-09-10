using OneReview.OverServices.Discounts;

namespace OneReview.OverServices;

public class PaymentServicesCreator
{
    readonly PaymentMethod _paymentType;
    readonly DiscountType _discountType;
    public PaymentServicesCreator(PaymentMethod payment, DiscountType discount)
    {
        _paymentType = payment;
        _discountType = discount;
    }

    public void Execute(decimal amount)
    {
        decimal discountAmount = DiscountStrategyFactory.CreateDiscountStrategy(_discountType).ApplyDiscount(amount);
        PaymentStrategyFactory.CreatePaymentService(_paymentType).ProcessPayment(discountAmount);
    }
}
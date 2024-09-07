namespace OneReview.Services;

public class OrderService
{
    private readonly IDiscountStrategy _discountStrategy;

    public OrderService(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void ProcessOrder(decimal totalAmount, IPaymentMethodStrategy paymentMethod)
    {
        totalAmount = _discountStrategy.ApplyDiscount(totalAmount);

        paymentMethod.ProcessPayment(totalAmount);
    }
}

namespace OneReview.Services;

public class PaymentContext(IPaymentStrategy paymentStrategy)
{
    private readonly IPaymentStrategy _paymentStrategy = paymentStrategy;

    public void ProcessPayment(decimal amount)
    {
        _paymentStrategy.ProcessPayment(amount);
    }
}

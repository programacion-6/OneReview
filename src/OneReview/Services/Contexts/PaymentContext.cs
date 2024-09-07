using OneReview.Services.Interfaces;

namespace OneReview.Services.Contexts;

public class PaymentContext(IPaymentStrategy paymentStrategy)
{
    private readonly IPaymentStrategy _paymentStrategy = paymentStrategy;

    public void PaymentExecution(decimal totalAmount)
    {
        _paymentStrategy.PaymentProcess(totalAmount);
    }
}

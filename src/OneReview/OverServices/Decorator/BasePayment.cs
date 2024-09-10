using OneReview.OverServices.Interfaces;

namespace OneReview.OverServices.Decorator;

public class BasePayment : IPayment
{
    private readonly IPaymentStrategy _paymentStrategy;
    private readonly decimal _baseAmount;

    public BasePayment(IPaymentStrategy paymentStrategy, decimal baseAmount)
    {
        _paymentStrategy = paymentStrategy;
        _baseAmount = baseAmount;
    }

    public decimal GetAmount()
    { 
        _paymentStrategy.ProcessPayment(_baseAmount);
        return _baseAmount;
    }
}

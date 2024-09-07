namespace OneReview.Services;

public class ProcessPaymentContext(IPaymentStrategy strategy)
{
    private readonly IPaymentStrategy _strategy = strategy;
    
    public decimal ProcessPayment(decimal amount)
    {
        return _strategy.ProcessPayment(amount);
    }
}

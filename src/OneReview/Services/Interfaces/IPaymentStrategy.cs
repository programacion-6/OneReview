namespace OneReview.Services;
public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}


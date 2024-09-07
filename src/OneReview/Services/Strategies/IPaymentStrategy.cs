namespace OneReview.Services.Strategies;

public interface IPaymentStrategy
{
    void ProcessPayment(decimal totalAmount);
}

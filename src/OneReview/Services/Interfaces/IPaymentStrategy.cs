namespace OneReview.Services.Interfaces;

public interface IPaymentStrategy
{
    void ProcessPayment(decimal totalAmount);
}
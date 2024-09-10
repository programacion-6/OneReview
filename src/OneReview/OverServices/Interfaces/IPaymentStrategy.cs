namespace OneReview.OverServices.Interfaces;

public interface IPaymentStrategy
{
    void ProcessPayment(decimal totalAmount);
}
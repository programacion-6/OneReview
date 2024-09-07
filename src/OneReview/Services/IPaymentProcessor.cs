namespace OneReview.Services;
public interface IPaymentProcessor
{
    void ProcessPayment(decimal totalAmount);
}

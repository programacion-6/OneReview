namespace OneReview.Services;

public interface IPaymentStrategy
{
    public void ProcessPayment(decimal totalAmount);
}

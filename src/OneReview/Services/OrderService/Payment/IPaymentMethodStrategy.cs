namespace OneReview.Services;

public interface IPaymentMethodStrategy
{
    public void ProcessPayment(decimal totalAmount);
}
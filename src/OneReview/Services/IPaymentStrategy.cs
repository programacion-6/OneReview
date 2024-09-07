namespace OneReview.Services;

public interface IPaymentStrategy
{
    decimal ProcessPayment(decimal amount);
}

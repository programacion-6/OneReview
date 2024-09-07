namespace OneReview.Services.Interfaces;

public interface IPaymentStrategy
{
    void PaymentProcess(decimal totalAmount);
}

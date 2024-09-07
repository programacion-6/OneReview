namespace OneReview.Services.OrderProccesing.PaymentMethods;

public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
}

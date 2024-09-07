using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Payment;

public class PayPalStrategy : IPaymentStrategy
{
    public void PaymentProcess(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through PayPal");
    }
}

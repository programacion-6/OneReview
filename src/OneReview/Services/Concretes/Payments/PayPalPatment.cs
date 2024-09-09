using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Payments;

public class PaypalPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through PayPal");
    }
}
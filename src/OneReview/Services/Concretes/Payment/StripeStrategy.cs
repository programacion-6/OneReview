using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Payment;

public class StripeStrategy : IPaymentStrategy
{
    public void PaymentProcess(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through Stripe");
    }
}

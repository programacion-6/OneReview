using OneReview.OverServices.Interfaces;

namespace OneReview.OverServices.Concretes.Payments;

public class StripePayment : IPaymentStrategy
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through Stripe");
    }
}
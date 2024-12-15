namespace OneReview.Services;

public class StripePaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} payment through Stripe");
    }
}
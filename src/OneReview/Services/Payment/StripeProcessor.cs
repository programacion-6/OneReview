namespace OneReview.Services;

public class StripeProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} payment through Stripe.");
    }
}

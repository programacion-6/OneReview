namespace OneReview.Services;
public class StripePaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through Stripe");
    }
}

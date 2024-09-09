namespace OneReview.Services;

public class StripeStrategy : IPaymentMethodStrategy
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through Stripe");
    }
}
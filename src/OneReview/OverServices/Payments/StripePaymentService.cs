namespace OneReview.OverServices.Payments;

public class StripePaymentService : IPaymentService
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} through Stripe");
    }
}

namespace OneReview.Services.OrderProccesing.PaymentMethods;

public class StripePayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} payment through Stripe");
    }

}

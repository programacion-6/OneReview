namespace OneReview.Services;

public class PaymentStripe : IPayment
{
    public void Pay(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through Stripe");
    }
}
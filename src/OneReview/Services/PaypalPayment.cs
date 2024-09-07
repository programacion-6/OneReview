namespace OneReview.Services;

public class PayPalPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through PayPal");
    }
}

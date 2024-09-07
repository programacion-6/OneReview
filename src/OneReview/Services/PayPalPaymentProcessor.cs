namespace OneReview.Services;
public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through PayPal");
    }
}

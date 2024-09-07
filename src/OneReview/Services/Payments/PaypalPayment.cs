namespace OneReview.Services;

public class PaypalPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through PayPal");
    }
}
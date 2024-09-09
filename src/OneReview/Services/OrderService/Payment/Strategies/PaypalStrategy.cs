namespace OneReview.Services;

public class PaypalStrategy : IPaymentMethodStrategy
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through PayPal");
    }
}
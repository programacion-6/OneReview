namespace OneReview.Services;

public class PaymentPaypal : IPayment
{
    public void Pay(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through PayPal");
    }
}
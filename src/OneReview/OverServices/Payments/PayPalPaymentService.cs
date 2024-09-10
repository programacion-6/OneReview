namespace OneReview.OverServices;

public class PayPalPaymentService : IPaymentService
{
    public void ProcessPayment(decimal amount)
    {  
        // Overly complex payment logic
        Console.WriteLine($"Processing {amount} through Paypal");
    }
}

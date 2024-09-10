using OneReview.OverServices.Discounts;

namespace OneReview.OverServices;

public class PayPalPaymentService : IPaymentService
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} through Paypal.");
    }
}

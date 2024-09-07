namespace OneReview.Services.OrderProccesing.PaymentMethods;

public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} payment through PayPal");
    }

}

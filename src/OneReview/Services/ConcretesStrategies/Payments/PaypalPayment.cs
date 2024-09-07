using OneReview.Services.Strategies;

namespace OneReview.Services.ConcretesStrategies.Payments;

public class PaypalPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through PayPal");
    }
}

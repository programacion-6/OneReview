public class PayPalPayment : IPaymentMethodStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} payment through PayPal");
    }
}

public class StripePayment : IPaymentMethodStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} payment through Stripe");
    }
}

public class BankTransferPayment : IPaymentMethodStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} payment through Bank Transfer");
    }
}

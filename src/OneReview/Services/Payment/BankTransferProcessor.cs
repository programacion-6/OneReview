namespace OneReview.Services;

public class BankTransferProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} payment through Bank Transfer.");
    }
}
namespace OneReview.Services;
public class BankTransferPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} payment through Bank Transfer");
    }
}

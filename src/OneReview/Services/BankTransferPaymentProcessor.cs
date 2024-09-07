namespace OneReview.Services;
public class BankTransferPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through Bank Transfer");
    }
}

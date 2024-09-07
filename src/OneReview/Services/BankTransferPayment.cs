namespace OneReview.Services;

public class BankTransferPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through Bank Transfer");
    }
}

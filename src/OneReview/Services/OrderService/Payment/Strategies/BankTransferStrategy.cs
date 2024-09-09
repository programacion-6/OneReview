namespace OneReview.Services;

public class BankTransferStrategy : IPaymentMethodStrategy
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through Bank Transfer");
    }
}
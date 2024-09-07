using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Payment;

public class BankTransferStrategy : IPaymentStrategy
{
    public void PaymentProcess(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through Bank Transfer");
    }
}

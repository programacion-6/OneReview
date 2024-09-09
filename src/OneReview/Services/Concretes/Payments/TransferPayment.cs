using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Payments;

public class TransferPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through Transfer");
    }
}
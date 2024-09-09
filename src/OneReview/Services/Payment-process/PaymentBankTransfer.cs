namespace OneReview.Services;

public class PaymentBankTransfer : IPayment
{
    public void Pay(decimal totalAmount)
    {
        Console.WriteLine($"Processing {totalAmount} payment through BankTransfer");
    }
}
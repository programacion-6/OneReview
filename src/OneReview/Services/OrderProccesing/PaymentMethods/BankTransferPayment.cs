namespace OneReview.Services.OrderProccesing.PaymentMethods;

public class BankTransferPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} payment through Bank Transfer");
    }

}

namespace OneReview.Services.Payments
{
    public class BankTransferPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal totalAmount)
        {
            Console.WriteLine($"Processing {totalAmount} payment through Bank Transfer");
        }
    }
}

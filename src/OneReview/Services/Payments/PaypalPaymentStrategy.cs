namespace OneReview.Services.Payments
{
    public class PaypalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal totalAmount)
        {
            Console.WriteLine($"Processing {totalAmount} payment through PayPal");
        }
    }
}
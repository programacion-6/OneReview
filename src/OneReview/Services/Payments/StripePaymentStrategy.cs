namespace OneReview.Services.Payments
{
    public class StripePaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal totalAmount)
        {
            Console.WriteLine($"Processing {totalAmount} payment through Stripe");
        }
    }
}

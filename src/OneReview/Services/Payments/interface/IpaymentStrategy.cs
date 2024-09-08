namespace OneReview.Services.Payments
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal totalAmount);
    }
}
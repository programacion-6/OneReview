namespace OneReview.Services;
public class PaymentProcessorFactory
{
    public static IPaymentProcessor CreatePaymentProcessor(string paymentMethod)
    {
        switch (paymentMethod)
        {
            case "PayPal":
                return new PayPalPaymentProcessor();
            case "Stripe":
                return new StripePaymentProcessor();
            case "BankTransfer":
                return new BankTransferPaymentProcessor();
            default:
                throw new NotSupportedException("Payment method not supported.");
        }
    }
}

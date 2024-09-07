public interface IPaymentMethodStrategy
{
    void ProcessPayment(decimal amount);
}
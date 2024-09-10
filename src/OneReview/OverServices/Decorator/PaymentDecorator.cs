namespace OneReview.OverServices.Decorator;

public abstract class PaymentDecorator : IPayment
{
    protected readonly IPayment _payment;

    protected PaymentDecorator(IPayment payment)
    {
        _payment = payment;
    }

    public virtual decimal GetAmount()
    {
        return _payment.GetAmount();
    }
}
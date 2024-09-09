namespace OneReview.Services;

public class PaymentContext 
{
    IPayment _payment;
    public void SetPayment(IPayment payment)
    {
        this._payment = payment;
    }

    public void Execute(decimal totalAmount)
    {
        _payment.Pay(totalAmount);
    } 
}
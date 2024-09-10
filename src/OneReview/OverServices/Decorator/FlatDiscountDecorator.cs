namespace OneReview.OverServices.Decorator;

public class FlatDiscountDecorator : PaymentDecorator
{
    public FlatDiscountDecorator(IPayment payment) : base(payment) {}
    
    public override decimal GetAmount()
    {
        return _payment.GetAmount() - DiscountConstants.DeafultAmountDiscount;
    }
}
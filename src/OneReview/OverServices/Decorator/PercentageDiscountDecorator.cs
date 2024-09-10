using OneReview.OverServices.Interfaces;

namespace OneReview.OverServices.Decorator;

public class PercentageDiscountDecorator : PaymentDecorator
{
    public PercentageDiscountDecorator(IPayment payment) : base(payment) {}
    
    public override decimal GetAmount()
    {
        return _payment.GetAmount() - (_payment.GetAmount() * DiscountConstants.DefaultIndexDiscount) ;
    }
}

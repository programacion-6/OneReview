namespace OneReview.OverServices;

/// <summary>
/// Issues
/// - Codigo Spaguetti (un poco). Por ejemplo, PaymentServiceFactory no need
/// - Strategy inside factory inside service
/// - classes with just static methods should ne be instantiated
/// - Acoplamiento - 
/// - Poor Responsibility Separation
/// - Diseño no escalable - Open / Closed matando 
/// How to fix
/// - Remove PaymentServiceFactory you can use Dependency Injection
/// - Separate the Discount Logic from the Payment Service
/// - Inject IDiscountStrategy
/// - Single Responsibility -> IPaymentService / IDiscountService
/// </summary>

public class PaymentServiceFactory
{
    public static IPaymentService CreatePaymentService(PaymentMethod paymentMethod)
    {
        return paymentMethod switch
        { 
            PaymentMethod.Paypal => new PayPalPaymentService(),
            PaymentMethod.Stripe => new StripePaymentService(),
            _ => throw new NotSupportedException("Payment method not supported"),
        };
    }
}

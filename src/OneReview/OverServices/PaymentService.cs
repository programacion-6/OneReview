using OneReview.OverServices.Interfaces;

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

public class PaymentService(IDiscountStrategy discountStrategy, IPaymentStrategy paymentStrategy)
{

    public void ProcessOrder(decimal totalAmount)
    {
        totalAmount = discountStrategy.ApplyDiscount(totalAmount);

        paymentStrategy.ProcessPayment(totalAmount);
    }
}
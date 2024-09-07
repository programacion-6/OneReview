using OneReview.Services.OrderProccesing.Discount;
using OneReview.Services.OrderProccesing.PaymentMethods;

namespace OneReview.Services.OrderProccesing;

/// <summary>
/// BAD PRACTICES
/// - No es flexible, no es facil extender el codigo, no es facil aumenter mas metodos de pago
/// - Estamos violando el single responsability
/// - encadenamiento largo de else if's
/// - No hay unidades de testeo / Es dificil de testear
/// - Violando el DRY
/// - Violando Open/Closed
/// - (~) Violando el KISS
/// - Violando PoLA
/// 
/// FIXING CODE
/// 1. Aplicar Strategy
/// </summary>
public class OrderService
{
    private readonly IDiscountStrategy _discountStrategy;
    private readonly IPaymentMethod _paymentMethod;

    public OrderService(IDiscountStrategy discountStrategy, IPaymentMethod paymentMethod)
    {
        _discountStrategy = discountStrategy;
        _paymentMethod = paymentMethod;
    }

    public void ProcessOrder(decimal totalAmount)
    {
        // apply discount
        totalAmount = _discountStrategy.ApplyDiscount(totalAmount);

        // process payment
        _paymentMethod.ProcessPayment(totalAmount);
    }
}

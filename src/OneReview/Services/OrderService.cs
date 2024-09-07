namespace OneReview.Services;

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
    public OrderService(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void ProcessOrder(decimal totalAmount, string paymentMethod)
    {
        // apply discount
        totalAmount = _discountStrategy.ApplyDiscount(totalAmount);

        // process payment
        var paymentProcessor = PaymentProcessorFactory.CreatePaymentProcessor(paymentMethod);
        paymentProcessor.ProcessPayment(totalAmount);
    }
}

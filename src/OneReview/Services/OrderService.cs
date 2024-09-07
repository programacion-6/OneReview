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
public class OrderService(IDiscountStrategy discountStrategy)
{
    private readonly IDiscountStrategy _discountStrategy = discountStrategy;

    public void ProcessOrder(decimal totalAmount, string paymentMethod)
    {
        // apply discount
        totalAmount = _discountStrategy.ApplyDiscount(totalAmount);

        // process payment
        if (paymentMethod == "PayPal")
        {
            Console.WriteLine($"Processing {totalAmount} payment through PayPal");
        }
        else if (paymentMethod == "Stripe")
        {
            Console.WriteLine($"Processing {totalAmount} payment through Stripe");
        }
        else if (paymentMethod == "BankTransfer")
        {
            Console.WriteLine($"Processing {totalAmount} payment through Bank Transfer");
        }
        else
        {
            throw new NotSupportedException("Payment method not supported.");
        }
    }
}

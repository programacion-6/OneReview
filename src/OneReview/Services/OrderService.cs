using OneReview.Services.Composites;
using OneReview.Services.Concretes.Payment;
using OneReview.Services.Concretes.Taxes;
using OneReview.Services.Contexts;
using OneReview.Services.Interfaces;

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

    public void ProcessOrder(decimal totalAmount)
    {
        // apply discount
        totalAmount = _discountStrategy.ApplyDiscount(totalAmount);

        // apply taxes
        var localTax = new LocalTax(0.45m);
        var stateTax = new StateTax(0.27m);
        var federalTax = new FederalTax(0.12m);

        var compositeTax = new CompositeTax();
        compositeTax.Add(localTax);
        compositeTax.Add(stateTax);
        compositeTax.Add(federalTax);

        decimal totalTax = compositeTax.CalculateTax(totalAmount);

        // payment process
        var bankTransferContext = new PaymentContext(new BankTransferStrategy());
        bankTransferContext.PaymentExecution(totalAmount + totalTax);

        var payPalContext = new PaymentContext(new PayPalStrategy());
        payPalContext.PaymentExecution(totalAmount + totalTax);

        var stripeContext = new PaymentContext(new StripeStrategy());
        stripeContext.PaymentExecution(totalAmount + totalTax);
    }
}

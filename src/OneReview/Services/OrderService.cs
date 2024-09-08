using OneReview.Domain;

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
    private readonly ProductTransactionService _productTransactionService;

    public OrderService(ProductTransactionService productTransactionService)
    {
        _productTransactionService = productTransactionService;
    }

    public void ProcessOrder(Product product)
    {
        _productTransactionService.ProcessPayment(product);
    }
}
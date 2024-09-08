namespace OneReview.Services;

using OneReview.Domain;
using OneReview.Services.Discounts;
using OneReview.Services.PriceDecorators;
using OneReview.Services.Payments;

public class ProductTransactionService
{
    private readonly DiscountContext _discountContext;
    private readonly IPaymentStrategy _paymentStrategy;

    public ProductTransactionService(IDiscountStrategy discountStrategy, IPaymentStrategy paymentStrategy)
    {
        _discountContext = new DiscountContext(discountStrategy);
        _paymentStrategy = paymentStrategy;
    }

    public decimal CalculateFinalPrice(Product product)
    {
        decimal discountedPrice = _discountContext.ProcessDiscount(product.BasePrice);

        IPriceCalculator priceCalculator = new BaseProductPrice(product, discountedPrice);
        priceCalculator = new TaxDecorator(priceCalculator);
        priceCalculator = new PromotionDecorator(priceCalculator);
        priceCalculator = new CategoryDiscountDecorator(priceCalculator, product);

        return priceCalculator.CalculatePrice();
    }

    public void ProcessPayment(Product product)
    {
        decimal finalPrice = CalculateFinalPrice(product);
        
        _paymentStrategy.ProcessPayment(finalPrice);
    }
}

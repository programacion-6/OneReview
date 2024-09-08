namespace OneReview.Services.PriceDecorators;
using OneReview.Domain;

public class BaseProductPrice : IPriceCalculator
{
    private readonly Product _product;

    public BaseProductPrice(Product product, decimal discountedPrice)
    {
        _product = product;
    }

    public decimal CalculatePrice()
    {
        return _product.BasePrice;
    }
}


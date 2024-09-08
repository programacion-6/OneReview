namespace OneReview.Services.PriceDecorators;
public class PromotionDecorator : IPriceCalculator
{
    private readonly IPriceCalculator _priceCalculator;
    private const decimal PromotionDiscount = 20;

    public PromotionDecorator(IPriceCalculator priceCalculator)
    {
        _priceCalculator = priceCalculator;
    }

    public decimal CalculatePrice()
    {
        var price = _priceCalculator.CalculatePrice();
        return price - PromotionDiscount;
    }
}


namespace OneReview.Services.PriceDecorators;
public class TaxDecorator : IPriceCalculator
{
    private readonly IPriceCalculator _priceCalculator;
    private const decimal TaxRate = 0.15m;

    public TaxDecorator(IPriceCalculator priceCalculator)
    {
        _priceCalculator = priceCalculator;
    }

    public decimal CalculatePrice()
    {
        var price = _priceCalculator.CalculatePrice();
        return price + (price * TaxRate);
    }
}


namespace OneReview.Services.PriceDecorators;
using OneReview.Domain;

public class CategoryDiscountDecorator : IPriceCalculator
{
    private readonly IPriceCalculator _priceCalculator;
    private readonly Product _product;

    public CategoryDiscountDecorator(IPriceCalculator priceCalculator, Product product)
    {
        _priceCalculator = priceCalculator;
        _product = product;
    }

    public decimal CalculatePrice()
    {
        var price = _priceCalculator.CalculatePrice();

        if (_product.Category == "Electronics")
        {
            return price - 30;
        }

        return price;
    }
}

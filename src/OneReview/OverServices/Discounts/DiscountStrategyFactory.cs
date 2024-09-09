namespace OneReview.OverServices.Discounts;

public class DiscountStrategyFactory
{
    public static IDiscountStrategy CreateDiscountStrategy(DiscountType discountType)
    {
        return discountType switch
        { 
            DiscountType.None => new NoDiscountStrategy(),
            DiscountType.Percentage => new PercentageDiscountStrategy(),
            DiscountType.Flat => new FlatRateDiscountStrategy(),
            _ => throw new NotSupportedException("Discount type not supported")
        };
    }
}

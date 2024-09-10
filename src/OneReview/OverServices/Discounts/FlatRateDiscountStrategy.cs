namespace OneReview.OverServices.Discounts;

public class FlatRateDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - DiscountsConstants.RateDiscount;
    }
}

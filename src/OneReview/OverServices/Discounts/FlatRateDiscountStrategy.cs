namespace OneReview.OverServices;

public class FlatRateDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - DiscountConstants.RateDiscount;
    }
}

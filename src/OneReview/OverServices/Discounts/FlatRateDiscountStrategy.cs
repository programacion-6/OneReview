namespace OneReview.OverServices.Discounts;

public class FlatRateDiscountStrategy : IDiscountStrategy
{
    private const decimal RateDiscount = 50;

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - RateDiscount;
    }
}

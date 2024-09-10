namespace OneReview.OverServices.DiscountsStrategy;

public class PercentageDiscountStrategy : IDiscountStrategy
{
    private const decimal PercentageDiscount = 0.1m;

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * PercentageDiscount);
    }
}

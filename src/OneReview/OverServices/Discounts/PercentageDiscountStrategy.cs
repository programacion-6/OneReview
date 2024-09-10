namespace OneReview.OverServices;

public class PercentageDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * DiscountConstants.PercentageDiscount);
    }
}

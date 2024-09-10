namespace OneReview.OverServices.DiscountsStrategy;

public class NoDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount;
    }
}

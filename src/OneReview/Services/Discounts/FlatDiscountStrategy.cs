namespace OneReview.Services;

public class FlatDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - DiscountConstants.DeafultAmountDiscount;
    }
}

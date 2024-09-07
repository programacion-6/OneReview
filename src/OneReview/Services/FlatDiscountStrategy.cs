namespace OneReview.Services;

public class FlatDiscountStrategy : IDiscountStrategy
{
    // class DiscountConstants
    private const decimal DefaultAmountDiscount = 50;

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - DefaultAmountDiscount;
    }
}

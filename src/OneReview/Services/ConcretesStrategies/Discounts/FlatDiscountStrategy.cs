using OneReview.Services.Strategies;

namespace OneReview.Services.ConcretesStrategies.Discounts;

public class FlatDiscountStrategy : IDiscountStrategy
{
    // class DiscountConstants
    private const decimal DeafultAmountDiscount = 50;

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - DeafultAmountDiscount;
    }
}

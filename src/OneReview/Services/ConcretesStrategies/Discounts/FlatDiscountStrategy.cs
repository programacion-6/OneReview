using OneReview.Services.Constants;
using OneReview.Services.Strategies;

namespace OneReview.Services.ConcretesStrategies.Discounts;

public class FlatDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - DiscountConstants.DeafultAmountDiscount;
    }
}

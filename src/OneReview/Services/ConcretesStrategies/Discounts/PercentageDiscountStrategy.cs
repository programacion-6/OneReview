using OneReview.Services.Constants;
using OneReview.Services.Strategies;

namespace OneReview.Services.ConcretesStrategies.Discounts;

public class PercentageDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * DiscountConstants.DefaultIndexDiscount);
    }
}

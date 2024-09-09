using OneReview.Services.DiscountConstants;
using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Discounts;

public class FlatDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - DiscountConstants.DeafultAmountDiscount;
    }
}
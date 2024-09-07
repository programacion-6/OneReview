using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Discount;

public class FlatDiscountStrategy : IDiscountStrategy
{
    // class DiscountConstants
    private const decimal DeafultAmountDiscount = 50;

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - DeafultAmountDiscount;
    }
}

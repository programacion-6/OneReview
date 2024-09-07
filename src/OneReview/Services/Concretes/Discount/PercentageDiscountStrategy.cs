using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Discount;

public class PercentageDiscountStrategy : IDiscountStrategy
{
    // class DiscountConstants
    private const decimal DefaultIndexDiscount = 0.1m;

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * DefaultIndexDiscount);
    }
}

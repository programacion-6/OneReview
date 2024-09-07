namespace OneReview.Services.Concretes;

public class PercentageDiscountStrategy : IDiscountStrategy
{
    // class DiscountConstants
    private const decimal DefaultIndexDiscount = 0.1m;

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * DefaultIndexDiscount);
    }
}

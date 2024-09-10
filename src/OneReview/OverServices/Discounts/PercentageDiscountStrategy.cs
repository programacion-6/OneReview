namespace OneReview.OverServices.Discounts;

public class PercentageDiscountStrategy : IDiscountStrategy
{

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * DiscountsConstants.PercentageDiscount);
    }
}

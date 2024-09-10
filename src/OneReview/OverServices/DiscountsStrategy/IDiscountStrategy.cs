namespace OneReview.OverServices.DiscountsStrategy;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

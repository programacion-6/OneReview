namespace OneReview.OverServices.Discounts;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

namespace OneReview.OverServices;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

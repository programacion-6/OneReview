namespace OneReview.Services;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

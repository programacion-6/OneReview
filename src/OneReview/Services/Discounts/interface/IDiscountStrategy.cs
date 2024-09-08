namespace OneReview.Services.Discounts;
public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

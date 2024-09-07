namespace OneReview.Services.Strategies;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

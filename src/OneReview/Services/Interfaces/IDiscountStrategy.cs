namespace OneReview.Services.Interfaces;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

namespace OneReview.OverServices.Interfaces;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

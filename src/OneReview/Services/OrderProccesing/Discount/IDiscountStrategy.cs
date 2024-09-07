namespace OneReview.Services.OrderProccesing.Discount;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

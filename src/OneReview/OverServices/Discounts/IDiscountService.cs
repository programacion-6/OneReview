namespace OneReview.OverServices.Discounts;


public interface IDiscountService
{
    decimal ApplyDiscount(decimal amount, DiscountType discountType);
}

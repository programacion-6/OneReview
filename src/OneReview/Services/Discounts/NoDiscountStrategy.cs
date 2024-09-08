using OneReview.Services.Discounts;

namespace ProductService.Services.Discounts;
public class NoDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal price)
    {
        return price;
    }
}

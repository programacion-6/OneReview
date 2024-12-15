namespace OneReview.Services;

public class DiscountContext(IDiscountStrategy strategy)
{
    private readonly IDiscountStrategy _strategy = strategy;
    
    public decimal ProcessDiscount(decimal totalAmount)
    {
        return _strategy.ApplyDiscount(totalAmount);
    }
}

namespace OneReview.Services;

public class DiscountContext
{
    private readonly IDiscountStrategy _strategy;
    public DiscountContext(IDiscountStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public decimal ProcessDiscount(decimal totalAmount)
    {
        return _strategy.ApplyDiscount(totalAmount);
    }
}

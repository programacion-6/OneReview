namespace OneReview.Services.Discounts;

public class DiscountContext
{
    private IDiscountStrategy _strategy;

    public DiscountContext(IDiscountStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

    public decimal ProcessDiscount(decimal totalAmount)
    {
        return _strategy.ApplyDiscount(totalAmount);
    }
    
}

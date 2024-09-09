namespace OneReview.Services;

public class ExpressShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderWeight, string destination)
    {
        return orderWeight * 10.0m;
    }
}
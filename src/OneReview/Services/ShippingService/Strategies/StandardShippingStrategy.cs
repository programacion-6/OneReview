namespace OneReview.Services;

public class StandardShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderWeight, string destination)
    {
        return orderWeight * 5.0m;
    }
}
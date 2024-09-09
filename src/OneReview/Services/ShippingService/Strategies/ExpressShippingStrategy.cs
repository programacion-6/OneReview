namespace OneReview.Services;

public class ExpressShippingStrategy : ShippingTemplate, IShippingStrategy
{
    public new decimal CalculateShippingCost(decimal orderWeight, string origin, string destination)
    {
        return CalculateCostByWeight(orderWeight) + CalculateCostByDistance(origin, destination) + ApplyAdditionalFees();
    }

    protected override decimal CalculateCostByDistance(string origin, string destination)
    {
        return 15.0m;
    }

    protected override decimal CalculateCostByWeight(decimal weight)
    {
        return weight * 5.0m;
    }
}
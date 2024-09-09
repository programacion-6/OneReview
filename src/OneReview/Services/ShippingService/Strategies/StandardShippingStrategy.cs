namespace OneReview.Services;

public class StandardShippingStrategy : AShippingTemplate
{
    
    public override decimal CalculateShippingCost(decimal orderWeight, string origin, string destination)
    {
        return CalculateCostByWeight(orderWeight) + CalculateCostByDistance(origin, destination);
    }

    protected override decimal CalculateCostByDistance(string origin, string destination)
    {
        return 8.0m;
    }

    protected override decimal CalculateCostByWeight(decimal weight)
    {
        return weight * 2.5m;
    }
}
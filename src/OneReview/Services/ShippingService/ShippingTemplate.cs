namespace OneReview.Services;

public abstract class ShippingTemplate
{
    public decimal CalculateShippingCost(decimal orderWeight, string origin, string destination)
    {
        decimal baseRate = CalculateCostByDistance(origin, destination);
        decimal weightCost = CalculateCostByWeight(orderWeight);
        decimal additionalFees = ApplyAdditionalFees();

        return baseRate + weightCost + additionalFees;
    }

    protected abstract decimal CalculateCostByDistance(string origin, string destination);

    protected abstract decimal CalculateCostByWeight(decimal weight);
    
    protected virtual decimal ApplyAdditionalFees()
    {
        return 10.0m;
    }
}
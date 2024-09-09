namespace OneReview.Services;

public abstract class AShippingTemplate
{
    public abstract decimal CalculateShippingCost(decimal orderWeight, string origin, string destination);

    protected abstract decimal CalculateCostByDistance(string origin, string destination);

    protected abstract decimal CalculateCostByWeight(decimal weight);
    
    protected virtual decimal ApplyAdditionalFees()
    {
        return 10.0m;
    }
}
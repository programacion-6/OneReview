namespace OneReview.Services;

public class ShippingService
{
    private readonly AShippingTemplate _shippingStrategy;

    public ShippingService(AShippingTemplate shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public decimal CalculateCost(decimal orderWeight, string origin, string destination)
    {
        return _shippingStrategy.CalculateShippingCost(orderWeight, origin, destination);
    }
}
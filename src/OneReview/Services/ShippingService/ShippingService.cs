namespace OneReview.Services;

public class ShippingService
{
    private readonly IShippingStrategy _shippingStrategy;

    public ShippingService(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public decimal CalculateCost(decimal orderWeight, string origin, string destination)
    {
        return _shippingStrategy.CalculateShippingCost(orderWeight, origin, destination);
    }
}
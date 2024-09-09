namespace OneReview.Services;

public interface IShippingStrategy
{
    decimal CalculateShippingCost(decimal orderWeight, string destination);
}
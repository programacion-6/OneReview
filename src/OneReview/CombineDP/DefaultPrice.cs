using OneReview.CombineDP;

public class DefaultPrice : IDiscountTypeStrategy
{
    public decimal CalculatePrice(decimal price)
    {
        return price;
    }
}
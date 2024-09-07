using OneReview.CombineDP;

public class DiscountPrice : IDiscountTypeStrategy
{
    public decimal CalculatePrice(decimal discountPrice)
    {
        return discountPrice * 0.9m; 
    }
}
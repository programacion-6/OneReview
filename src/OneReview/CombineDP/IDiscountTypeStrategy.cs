namespace OneReview.CombineDP;
public interface IDiscountTypeStrategy
{
    decimal CalculatePrice(decimal price);
}
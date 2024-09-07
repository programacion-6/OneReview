namespace OneReview.CombineDP;
public abstract class OrderService
{
    private readonly IDiscountTypeStrategy _discountType;

    protected OrderService(IDiscountTypeStrategy discountType)
    {
        _discountType = discountType;
    }

    public decimal ProcessOrder(decimal unitPrice)
    {
        ValidateOrder();
        var price = CalculatePrice(unitPrice);
        DeliveryOrder();
        return price;
    }

    protected abstract void ValidateOrder();

    protected decimal CalculatePrice(decimal price)
    {
        return _discountType.CalculatePrice(price);
    }

    protected abstract void DeliveryOrder();
}
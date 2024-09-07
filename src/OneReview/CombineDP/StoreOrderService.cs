namespace OneReview.CombineDP;
public class StoreOrderService : OrderService
{
    public StoreOrderService(IDiscountTypeStrategy discountStrategy) 
        : base(discountStrategy)
    {
    }

    protected override void ValidateOrder()
    {
        Console.WriteLine("Validating order");
    }

    protected override void DeliveryOrder()
    {
        Console.WriteLine("Sending order");
    }
}
public class StoreDelivery : DeliveryStrategy
{
    private const decimal DefaultAmountDiscount = 0.2m;
    public decimal Delivery(decimal deliveryCost)
    {
        return deliveryCost - (deliveryCost * DefaultAmountDiscount);
    }
}

public class HomeDelivery : DeliveryStrategy
{
    private const decimal DefaultAmount = 20;
    public decimal Delivery(decimal deliveryCost)
    {
        return deliveryCost + DefaultAmount;
    }
}
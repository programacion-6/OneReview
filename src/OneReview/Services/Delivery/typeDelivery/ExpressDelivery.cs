public class ExpressDelivery : HomeDeliveryTypeTemplate
{
    private const decimal DefaultAmount = 5;

    public decimal AdditionalCostDelivery(decimal amount)
    {
        return amount + DefaultAmount;    
    }
}
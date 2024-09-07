namespace OneReview.CombineDP;
public class Program
{
    public static void Main()
    {
        StoreOrderService order1 = new StoreOrderService(new DefaultPrice());
        Console.WriteLine(order1.ProcessOrder(10m));  

        StoreOrderService order2 = new StoreOrderService(new DiscountPrice());
        Console.WriteLine(order2.ProcessOrder(10m));  

    }
}
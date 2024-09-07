namespace OneReview.Services.Inventory;

public class StockAlertObserver : IStockObserver
{
    private readonly int _limit;

    public StockAlertObserver(int limit)
    {
        _limit = limit;
    }

    public void Notify(string productName, int stock)
    {
        if (stock < _limit)
        {
            Console.WriteLine($"Stock alert: {productName} has {stock} items left");
        }
    }

}

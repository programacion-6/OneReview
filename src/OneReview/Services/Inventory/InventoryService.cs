namespace OneReview.Services.Inventory;

public class InventoryService
{
    private static InventoryService _instance;
    private readonly List<IStockObserver> _observers;
    private readonly Dictionary<string, int> _stock;

    private InventoryService()
    {
        _stock = new Dictionary<string, int>();
        _observers = new List<IStockObserver>();
    }

    public static InventoryService GetInstance()
    {
        if (_instance is null)
        {
            _instance = new InventoryService();
        }

        return _instance;
    }

    public void AddObserver(IStockObserver observer) 
    {
        _observers.Add(observer);
    }

    public void UpdateStock(string productName, int quantity)
    {
        if (_stock.ContainsKey(productName))
        {
            _stock[productName] = quantity;
        }
        else
        {
            _stock.Add(productName, quantity);
        }

        NotifyObservers(productName, quantity);
    }

    private void NotifyObservers(string productName, int stock)
    {
        foreach (var observer in _observers)
        {
            observer.Notify(productName, stock);
        }
    }
}

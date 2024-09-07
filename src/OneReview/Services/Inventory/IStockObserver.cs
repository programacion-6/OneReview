namespace OneReview.Services.Inventory;

public interface IStockObserver
{
    void Notify(string productName, int stock);
}

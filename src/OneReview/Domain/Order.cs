namespace OneReview.Domain;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public DateTime Date { get; set; }

    public Dictionary<Product,int> Products { get; set; }
    public int TotalAmount { get; set; }

    public Order()
    {
        Date = DateTime.Now;
    }
}

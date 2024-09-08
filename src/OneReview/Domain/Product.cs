namespace OneReview.Domain;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; }

    public string Description { get; set; }

    public string Category { get; set; }

    public string SubCategory { get; set; }
    public decimal BasePrice { get; set; }
}

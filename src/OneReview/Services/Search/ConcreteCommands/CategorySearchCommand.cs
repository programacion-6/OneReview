using OneReview.Domain;
using OneReview.Services.Search.Commands;

namespace OneReview.Services.Search.ConcreteCommands;

public class CategorySearchCommand(string category) : ProductSearchTemplate, ICommand
{
    private readonly string _category = category;

    protected override List<Product> ApplyFilters(List<Product> products)
    {
        return products.Where(p => p.Category == _category).ToList();
    }

    public List<Product> Execute()
    {
        return Search(); 
    }
}


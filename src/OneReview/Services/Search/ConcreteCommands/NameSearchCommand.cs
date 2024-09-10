using OneReview.Domain;
using OneReview.Services.Search.Commands;

namespace OneReview.Services.Search.ConcreteCommands;

public class NameSearchCommand(string name) : ProductSearchTemplate, ICommand
{
    private readonly string _name = name;

    protected override List<Product> ApplyFilters(List<Product> products)
    {
        return products.Where(p => p.Name.Contains(_name, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Product> Execute()
    {
        return Search();
    }
}

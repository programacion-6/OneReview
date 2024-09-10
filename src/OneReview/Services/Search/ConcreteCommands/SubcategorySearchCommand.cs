using OneReview.Domain;
using OneReview.Services.Search.Commands;

namespace OneReview.Services.Search.ConcreteCommands;

public class SubCategorySearchCommand(string subCategory) : ProductSearchTemplate, ICommand
{
    private readonly string _subCategory = subCategory;

    protected override List<Product> ApplyFilters(List<Product> products)
    {
        return products.Where(p => p.SubCategory == _subCategory).ToList();
    }

    public List<Product> Execute()
    {
        return Search();
    }
}


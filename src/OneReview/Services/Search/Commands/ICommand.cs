using OneReview.Domain;

namespace OneReview.Services.Search.Commands;

public interface ICommand
{
    List<Product> Execute();
}

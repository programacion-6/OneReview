using OneReview.Services.Search.Commands;

namespace OneReview.Services.Search;

public class SearchCommandInvoker
{
private readonly List<ICommand> _commands = [];

    public void AddCommand(ICommand command)
    {
        _commands.Add(command);
    }

    public void ExecuteCommands()
    {
        foreach (var command in _commands)
        {
            var products = command.Execute();
            Console.WriteLine("Products Found:");
            products.ForEach(p => Console.WriteLine($"- {p.Name}, {p.Category}, ${p.SubCategory}"));
        }
    }
}

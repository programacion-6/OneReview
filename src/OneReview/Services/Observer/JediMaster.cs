namespace OneReview.Services;

public class JediMaster : IObserver
{
    private string _name;

    public JediMaster(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} ha sido notificado: {message}");
    }
}
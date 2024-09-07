namespace OneReview.Services;

public class ForceEvent : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }

    public void UseForce(string forceAction)
    {
        Console.WriteLine($"El uso de la Fuerza: {forceAction}");
        Notify($"Un Jedi ha usado la Fuerza para {forceAction}");
    }
}
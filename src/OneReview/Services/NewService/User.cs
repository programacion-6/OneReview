public class User : ISubscriber
{
    public string Name { get; }

    public User(string name)
    {
        Name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{Name} received notification: {message}");
    }
}

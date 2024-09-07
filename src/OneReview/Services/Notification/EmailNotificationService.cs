namespace OneReview.Services;

public class EmailNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}

namespace OneReview.Services;
public class SMSNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}

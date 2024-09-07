public class EmailNotification : INotificationStrategy
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"Sending Email to {recipient}: {message}");
    }
}

public class SmsNotification : INotificationStrategy
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"Sending SMS to {recipient}: {message}");
    }
}

public class PushNotification : INotificationStrategy
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
    }
}

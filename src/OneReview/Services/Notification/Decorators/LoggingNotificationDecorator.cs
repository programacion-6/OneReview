namespace OneReview.Services;
public class LoggingNotificationDecorator : NotificationDecorator
{
    public LoggingNotificationDecorator(INotificationService notificationService)
        : base(notificationService)
    {
        
    }

    public override void Send(string message)
    {
        Console.WriteLine($"Logging message: {message}");
        base.Send(message);
    }
}

public class LoggingNotificationDecorator : NotificationDecorator
{
    public LoggingNotificationDecorator(INotificationStrategy notification)
        : base(notification) { }

    public override void Send(string message, string recipient)
    {
        base.Send(message, recipient);
        Log(message, recipient);
    }

    private void Log(string message, string recipient)
    {
        Console.WriteLine($"Logging: Message '{message}' sent to {recipient}");
    }
}

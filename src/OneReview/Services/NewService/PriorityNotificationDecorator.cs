public class PriorityNotificationDecorator : NotificationDecorator
{
    private readonly int _priority;

    public PriorityNotificationDecorator(INotificationStrategy notification, int priority)
        : base(notification)
    {
        _priority = priority;
    }

    public override void Send(string message, string recipient)
    {
        Console.WriteLine($"Priority {_priority} notification:");
        base.Send(message, recipient);
    }
}

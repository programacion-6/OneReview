public abstract class NotificationDecorator : INotificationStrategy
{
    protected INotificationStrategy _notification;

    public NotificationDecorator(INotificationStrategy notification)
    {
        _notification = notification;
    }

    public virtual void Send(string message, string recipient)
    {
        _notification.Send(message, recipient);
    }
}

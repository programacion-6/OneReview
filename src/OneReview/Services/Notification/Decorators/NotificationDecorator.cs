namespace OneReview.Services;
public abstract class NotificationDecorator : INotificationService
{
    protected readonly INotificationService _notificationService;

    public NotificationDecorator(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void Send(string message)
    {
        _notificationService.Send(message);
    }
}

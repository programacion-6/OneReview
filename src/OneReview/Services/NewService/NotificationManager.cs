public class NotificationManager
{
    private readonly NotificationService _notificationService;

    public NotificationManager(NotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void NotifyUsers(string message, INotificationStrategy notificationStrategy)
    {
        _notificationService.NotifyAll(message);

        notificationStrategy.Send(message, "All Users");
    }
}

namespace OneReview.Services;

public class EmailNotificationFactory : NotificationFactory
{
    public override INotificationService CreateNotificationService()
    {
        return new EmailNotificationService();
    }
}

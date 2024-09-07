namespace OneReview.Services;

public class SMSNotificationFactory : NotificationFactory
{
    public override INotificationService CreateNotificationService()
    {
        return new SMSNotificationService();
    }
}
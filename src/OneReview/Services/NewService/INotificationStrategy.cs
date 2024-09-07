public interface INotificationStrategy
{
    void Send(string message, string recipient);
}

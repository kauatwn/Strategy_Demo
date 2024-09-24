using Domain.Interfaces.Strategies;

namespace Infrastructure.Strategies.Notifications;

public class SmsNotificationStrategy : INotificationStrategy
{
    public string Send(string sender, string recipient, string content)
    {
        return $"SMS sent from {sender} to {recipient} with content: {content}";
    }
}
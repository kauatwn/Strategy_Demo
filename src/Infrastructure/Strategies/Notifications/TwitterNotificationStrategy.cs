using Domain.Interfaces.Strategies;

namespace Infrastructure.Strategies.Notifications;

public class TwitterNotificationStrategy : INotificationStrategy
{
    public string Send(string sender, string recipient, string content)
    {
        return $"Tweet sent from {sender} to {recipient} with content: {content}";
    }
}
using Domain.Interfaces.Strategies;

namespace Infrastructure.Strategies.Notifications;

public class EmailNotificationStrategy : INotificationStrategy
{
    public string Send(string sender, string recipient, string content)
    {
        return $"Email sent from {sender} to {recipient} with content: {content}";
    }
}
using Domain.Interfaces.Strategies;

namespace Infrastructure.Strategies.Notifications;

public class WhatsAppNotificationStrategy : INotificationStrategy
{
    public string Send(string sender, string recipient, string content)
    {
        return $"WhatsApp message sent from {sender} to {recipient} with content: {content}";
    }
}
using Application.Abstractions.UseCases;
using Application.Contexts;
using Domain.Entities;

namespace Application.UseCases.Notifications;

public class SendNotificationUseCase(NotificationContext notificationContext) : ISendNotificationUseCase
{
    private NotificationContext NotificationContext { get; } = notificationContext;

    public string Execute(Notification notification)
    {
        if (!notification.Channel.HasValue)
        {
            throw new InvalidOperationException("Notification channel is not set.");
        }
        
        NotificationContext.SetStrategy(notification.Channel.Value);
        return NotificationContext.Send(notification.Sender, notification.Recipient, notification.Content);
    }
}
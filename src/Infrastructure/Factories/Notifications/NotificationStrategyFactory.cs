using Domain.Enums;
using Domain.Interfaces.Factories;
using Domain.Interfaces.Strategies;

namespace Infrastructure.Factories.Notifications;

public class NotificationStrategyFactory : INotificationStrategyFactory
{
    public INotificationStrategy GetNotificationStrategy(NotificationChannel channel)
    {
        return channel switch
        {
            NotificationChannel.Email => new EmailNotificationFactory().Create(),
            NotificationChannel.Sms => new SmsNotificationFactory().Create(),
            NotificationChannel.Twitter => new TwitterNotificationFactory().Create(),
            NotificationChannel.WhatsApp => new WhatsAppNotificationFactory().Create(),
            _ => throw new InvalidOperationException("Invalid notification channel.")
        };
    }
}
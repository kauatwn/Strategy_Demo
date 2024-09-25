using Domain.Enums;
using Domain.Interfaces.Factories;
using Domain.Interfaces.Strategies;

namespace Infrastructure.Factories.Notifications;

public class NotificationStrategyFactory : INotificationStrategyFactory
{
    public INotificationStrategy GetStrategy(NotificationChannel channel)
    {
        INotificationFactory factory = channel switch
        {
            NotificationChannel.Email => new EmailNotificationFactory(),
            NotificationChannel.Sms => new SmsNotificationFactory(),
            NotificationChannel.Twitter => new TwitterNotificationFactory(),
            NotificationChannel.WhatsApp => new WhatsAppNotificationFactory(),
            _ => throw new InvalidOperationException("Invalid notification channel.")
        };
        
        return factory.Create(); 
    }
}
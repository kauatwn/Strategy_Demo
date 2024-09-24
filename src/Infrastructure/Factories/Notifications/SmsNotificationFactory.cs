using Domain.Interfaces.Strategies;
using Infrastructure.Factories.Notifications.Base;
using Infrastructure.Strategies.Notifications;

namespace Infrastructure.Factories.Notifications;

public class SmsNotificationFactory : NotificationFactory
{
    public override INotificationStrategy Create()
    {
        return new SmsNotificationStrategy();
    }
}
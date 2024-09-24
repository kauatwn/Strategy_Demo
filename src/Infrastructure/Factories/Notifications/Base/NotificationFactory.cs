using Domain.Interfaces.Factories;
using Domain.Interfaces.Strategies;

namespace Infrastructure.Factories.Notifications.Base;

public abstract class NotificationFactory : INotificationFactory
{
    public abstract INotificationStrategy Create();
}
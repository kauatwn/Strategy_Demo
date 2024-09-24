using Domain.Enums;
using Domain.Interfaces.Strategies;

namespace Domain.Interfaces.Factories;

public interface INotificationStrategyFactory
{
    INotificationStrategy GetNotificationStrategy(NotificationChannel channel);
}
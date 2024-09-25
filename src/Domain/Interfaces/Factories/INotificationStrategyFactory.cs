using Domain.Enums;
using Domain.Interfaces.Strategies;

namespace Domain.Interfaces.Factories;

public interface INotificationStrategyFactory
{
    INotificationStrategy GetStrategy(NotificationChannel channel);
}
using Domain.Enums;
using Domain.Interfaces.Factories;
using Domain.Interfaces.Strategies;

namespace Application.Contexts;

public class NotificationContext(INotificationStrategy strategy, INotificationStrategyFactory strategyFactory)
{
    private INotificationStrategy Strategy { get; set; } = strategy;
    private INotificationStrategyFactory StrategyFactory { get; } = strategyFactory;

    public void SetStrategy(NotificationChannel channel)
    {
        Strategy = StrategyFactory.GetStrategy(channel);
    }

    public string Send(string sender, string recipient, string content)
    {
        return Strategy.Send(sender, recipient, content);
    }
}
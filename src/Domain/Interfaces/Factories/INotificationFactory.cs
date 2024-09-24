using Domain.Interfaces.Strategies;

namespace Domain.Interfaces.Factories;

public interface INotificationFactory
{
    INotificationStrategy Create();
}
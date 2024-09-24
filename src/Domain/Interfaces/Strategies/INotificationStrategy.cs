namespace Domain.Interfaces.Strategies;

public interface INotificationStrategy
{
    string Send(string sender, string recipient, string content);
}
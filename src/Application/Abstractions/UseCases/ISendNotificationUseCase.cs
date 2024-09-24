using Domain.Entities;

namespace Application.Abstractions.UseCases;

public interface ISendNotificationUseCase
{
    string Execute(Notification notification);
}
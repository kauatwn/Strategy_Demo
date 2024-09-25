using Application.Abstractions.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificationsController : ControllerBase
{
    [HttpPost]
    public IActionResult SendNotification(ISendNotificationUseCase useCase, Notification notification)
    {
        var result = useCase.Execute(notification);
        return Ok(result);
    }
}
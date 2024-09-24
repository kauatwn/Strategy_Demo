using Domain.Enums;

namespace Domain.Entities;

public class Notification
{
    public string Sender { get; set; } = string.Empty;
    public string Recipient { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public NotificationChannel? Channel { get; set; }
}
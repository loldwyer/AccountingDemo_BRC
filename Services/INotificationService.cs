namespace AccountingDemo_BRC.Services;

public interface INotificationService
{
    // Asynchronous method for sending a notification.
    // Any class implementing the interface provides
    // its own logic for how the message is delivered (email, texts, etc.).
    Task SendAsync(string message);
}
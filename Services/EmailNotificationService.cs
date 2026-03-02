namespace AccountingDemo_BRC.Services;

// Follows DIP, 
//Higher level module (invoice service) depends on INotificationServicee abstraction (interface), 
//not this EmailNotificationService implementation
public class EmailNotificationService : INotificationService
{
    // Simulate sending email asynchronously
    public async Task SendAsync(string message)
    {
        await Task.Delay(500); // Simulate delay w/o blocking the main thread (e.eg.calling an external email API)
        Console.WriteLine($"[EMAIL SENT]: {message}");
    }
}
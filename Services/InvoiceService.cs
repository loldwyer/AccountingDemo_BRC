using AccountingDemo_BRC.Models;

namespace AccountingDemo_BRC.Services;

// Follows SRP - this class is responsible for invoice-related operations, not how notifications are sent
public class InvoiceService
{
    // Follows DIP -depends on INotificationService abstraction, not a concrete implementation
    private readonly INotificationService _notificationService;
        // DIP -Constructor injection for the notification service
        //notification service is provided from outside this class, 
        // allowing for flexibility and easier testing (e.g., can inject a mock notification service during unit tests)
        public InvoiceService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    //Async method that simulates creating invoices
    public async Task<List<Invoice>> CreateSampleInvoicesAsync()
    {
        //simulate a database filled with invoices
        var invoices = new List<Invoice>
        {
            new Invoice("BRC-101", "John Smith Mechanics Ltd", 1200m, false),
            new Invoice("BRC-102", "Coffee&Go Co", 850m, true),
            new Invoice("BRC-103", "JJ Builders", 2150m, false)
        };
        //send notification that invoices were created, without blocking the main thread
        var notifInvoice = _notificationService.SendAsync("Sample invoices created.");
        await notifInvoice; //wait for notification to be sent before proceeding (e.g., if we wanted to log that the notification was sent successfully before returning the invoices)
        return invoices; //return the list of invoices after notification is sent
    }
}
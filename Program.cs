using AccountingDemo_BRC.Models; // invoice class
using AccountingDemo_BRC.Services; // invoice service, notification service, email notification service

Console.WriteLine("=== BRC Mini Accounting Demo ===");

// Dependency Injection of notification service
var invoiceService = new InvoiceService(new EmailNotificationService()); //DIP

//async/await to create sample invoices and send notification
var invoices = await invoiceService.CreateSampleInvoicesAsync();

Console.WriteLine("\nAll Invoices:");
foreach (var invoice in invoices)
{
    Console.WriteLine($"{invoice.InvoiceNumber} | {invoice.CustomerName} | {invoice.Amount:C} | Paid: {invoice.IsPaid}");
}
Console.WriteLine("\nTotal Revenue (LINQ Sum):");

// LINQ Sum() to calculate total revenue
var totalRevenue = invoices.Sum(i => i.Amount);
Console.WriteLine(totalRevenue.ToString("C"));

// LINQ Any() to check for unpaid invoices
Console.WriteLine("\nHas any unpaid invoice? (LINQ Any):");
Console.WriteLine(invoices.Any(i => !i.IsPaid));

//LINQ OrderByDescending + FirstOrDefault to find highest invoice
// returns null if no invoices
Console.WriteLine("\nHighest invoice (LINQ OrderByDescending + FirstOrDefault):");
var highest = invoices.OrderByDescending(i => i.Amount).FirstOrDefault();
if (highest != null)
{
    Console.WriteLine($"{highest.InvoiceNumber} - {highest.Amount:C}");
}

//LINQ GroupBy to group invoices by paid status
Console.WriteLine("\nInvoices grouped by Paid status (LINQ GroupBy):");
var grouped = invoices.GroupBy(i => i.IsPaid);

foreach (var group in grouped)
{
    Console.WriteLine(group.Key ? "Paid" : "Unpaid");
    foreach (var invoice in group)
    {
        Console.WriteLine($"  {invoice.InvoiceNumber} - {invoice.Amount:C}");
    }
}

Console.WriteLine("\nDemo complete.");
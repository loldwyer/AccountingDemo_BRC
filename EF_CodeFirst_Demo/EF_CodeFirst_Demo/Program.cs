using EF_CodeFirst_Demo;
using EF_CodeFirst_Demo.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("=== EF Core Code First Demo ===");

using var db = new BrcContext();

// Seed once
if (!await db.Customers.AnyAsync())
{
    var customer = new Customer
    {
        Name = "Dublin Bikes Ltd",
        Email = "info@dublinbikes.ie"
    };

    db.Customers.Add(customer);

    db.Invoices.Add(new Invoice
    {
        Customer = customer,
        Amount = 1200m,
        IsPaid = false
    });

    await db.SaveChangesAsync();
}

// Query using Include + projection
var invoices = await db.Invoices
    .Include(i => i.Customer)
    .Select(i => new { i.Id, i.Amount, i.IsPaid, CustomerName = i.Customer!.Name })
    .ToListAsync();

foreach (var i in invoices)
{
    Console.WriteLine($"{i.Id} | {i.CustomerName} | {i.Amount} | Paid: {i.IsPaid}");
}
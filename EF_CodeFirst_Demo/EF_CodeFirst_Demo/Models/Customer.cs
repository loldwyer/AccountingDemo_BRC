namespace EF_CodeFirst_Demo.Models;

// Customer table (1-to-many with invoices)
public class Customer
{
    public int Id { get; set; }                 // Primary Key
    public string Name { get; set; } = "";      // Customer name
    public string Email { get; set; } = "";     // Customer email

    // Navigation property (Customer -> many Invoices)
    public List<Invoice> Invoices { get; set; } = new();
}
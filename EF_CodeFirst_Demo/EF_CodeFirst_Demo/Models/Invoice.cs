namespace EF_CodeFirst_Demo.Models;

// Invoice table
public class Invoice
{
    public int Id { get; set; }                 // Primary Key
    public decimal Amount { get; set; }         // Invoice amount
    public bool IsPaid { get; set; }            // Payment status

    // Foreign Key + navigation property (Invoice -> one Customer)
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
}
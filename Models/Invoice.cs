namespace AccountingDemo_BRC.Models;

public class Invoice
{
    public string InvoiceNumber { get; set; }
    public string CustomerName { get; set; }
    public decimal Amount { get; set; }
    public bool IsPaid { get; set; }

    public Invoice(string invoiceNumber, string customerName, decimal amount, bool isPaid)
    {
        InvoiceNumber = invoiceNumber;
        CustomerName = customerName;
        Amount = amount;
        IsPaid = isPaid;
    }
}
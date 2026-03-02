using EF_CodeFirst_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst_Demo;

// DbContext = session with the database. Code First uses this + migrations to create schema.
public class BrcContext : DbContext
{
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Invoice> Invoices => Set<Invoice>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=BRC_EFCore_Demo;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
# AccountingDemo_BRC

A small C# console application demonstrating:

- C# coding conventions
- SOLID principles
- LINQ queries
- Asynchronous programming (async/await)
- Basic dependency injection
- Entity Framework Core (Code First) with SQL Server and migrations

Inspired by a simple accounting scenario (invoice management and revenue tracking).

---

## Project Structure

This repository contains two demos:

### Core C# Demo (Root Project)

Focuses on:

- Clean architecture principles
- SOLID design
- LINQ queries
- Async/await patterns
- Dependency injection

### EF Core Code First Demo

Location:    EF_CodeFirst_Demo/EF_CodeFirst_Demo


Focuses on:

- ORM usage with Entity Framework Core
- Code First workflow
- SQL Server integration
- Database migrations
- Persisted data querying

---

## Features (Core C# Demo)

- Creates sample invoices
- Sends a notification asynchronously
- Calculates total revenue using LINQ
- Checks for unpaid invoices
- Finds highest invoice
- Groups invoices by payment status

---

## SOLID Principles Demonstration

### SRP (Single Responsibility Principle)

Each class has one responsibility:

- `Invoice` handles data.
- `InvoiceService` handles business logic.
- `EmailNotificationService` handles notifications.

### OCP (Open/Closed Principle)

The system can be extended without modifying existing code.

- A `SmsNotificationService` could be added without changing `InvoiceService`.

### LSP (Liskov Substitution Principle)

Any class implementing `INotificationService` can replace another without breaking functionality.

- `EmailNotificationService` and `SmsNotificationService` are interchangeable.

### ISP (Interface Segregation Principle)

Interfaces are small and focused.

- `INotificationService` contains only one method: `SendAsync`.

### DIP (Dependency Inversion Principle)

High-level modules depend on abstractions, not concrete implementations.

- `InvoiceService` depends on `INotificationService`, not directly on `EmailNotificationService`.

---

## EF Core Code First Demonstration

This project expands the original in-memory demo by introducing database persistence using SQL Server.

### What It Demonstrates

- C# models mapped to relational tables
- Custom `DbContext` implementation (`BrcContext`)
- One-to-many relationship (Customer → Invoices)
- Code First database creation
- Migrations (`InitialCreate`)
- Seeding data via C#
- LINQ queries translated into SQL
- Verification of results in SSMS

### Database Created
BRC_EFCore_Demo

Tables created:

- `dbo.Customers`
- `dbo.Invoices`
- `__EFMigrationsHistory`

---

## Running the Core C# Demo

From the repository root:

```bash
git clone https://github.com/loldwyer/AccountingDemo_BRC.git
cd AccountingDemo_BRC
dotnet run
```
## Recreating the Database
```bash
cd EF_CodeFirst_Demo/EF_CodeFirst_Demo
dotnet ef migrations add InitialCreate --context BrcContext
dotnet ef database update --context BrcContext
```

## Tools used:
- .NET CLI
- Git Bash
- SQL Server
- SQL Server Configuration Manager (TCP/IP enabled)
- SQL Server Management Studio (SSMS)
- Entity Framework Core
- EF Migrations

A small C# console application demonstrating:
* C# coding conventions
* SOLID principles
* LINQ queries
* Asynchronous programming (async/await)
* Basic dependency injection

Inspired by a simple accounting scenario (invoice management and revenue tracking).

Features:
* Creates sample invoices
* Sends a notification asynchronously
* Calculates total revenue using LINQ
* Checks for unpaid invoices
* Finds highest invoice
* Groups invoices by payment status

SOLID Principles Demonstration
* SRP (Single Responsibility Principle) – Each class has one responsibility.
  * Invoice handles data.
  * InvoiceService handles business logic.
  * EmailNotificationService handles notifications.
* OCP (Open/Closed Principle) – The system can be extended without modifying existing code.
  * You can add SmsNotificationService without changing InvoiceService.
* LSP (Liskov Substitution Principle) – Any class implementing INotificationService can replace another without breaking the program.
  * EmailNotificationService and SmsNotificationService are interchangeable.
* ISP (Interface Segregation Principle) – Interfaces are small and focused.
  * INotificationService only contains one method: SendAsync.
* DIP (Dependency Inversion Principle) – High-level modules depend on abstractions, not concrete implementations.
  * InvoiceService depends on INotificationService, not directly on EmailNotificationService.

Run the Project
* git clone https://github.com/loldwyer/AccountingDemo_BRC.git
* cd AccountingDemo_BRC
* dotnet run

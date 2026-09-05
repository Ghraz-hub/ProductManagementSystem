using ProductManagementSystem.App.Customers.Models;

namespace ProductManagementSystem.App.Customers.Services;

public interface ICustomerService
{
    Customer AddCustomer(Guid Id, string firstName, string lastName, string emailAddress, string? phoneNumber);

    IReadOnlyList<Customer> GetAllCustomers();
}

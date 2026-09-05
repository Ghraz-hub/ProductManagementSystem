using ProductManagementSystem.App.Customers.Models;

namespace ProductManagementSystem.App.Customers.Services;

public class CustomerService : ICustomerService
{
    private readonly List<Customer> _customerList = [];

    public Customer AddCustomer(Guid id, string firstName,string lastName, string emailAddress, string? phoneNumber)
    {

        var customer = CreateCustomer(id, firstName, lastName, emailAddress, phoneNumber);

        _customerList.Add(customer);

        return customer;
    }
    public IReadOnlyList<Customer> GetAllCustomers()
    {
        return _customerList;
    }

    private static Customer CreateCustomer(Guid id, string firstName, string lastName, string email, string? phoneNumber) =>
        new(Guid.NewGuid(), firstName.Trim(), lastName.Trim(), email.ToLower(), phoneNumber);

    
}

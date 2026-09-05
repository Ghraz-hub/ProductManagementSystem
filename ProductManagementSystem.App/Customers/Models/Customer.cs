namespace ProductManagementSystem.App.Customers.Models;

public class Customer(Guid id, string firstName, string lastName, string emailAddress, string? phoneNumber = null)
{
    public Guid Id { get; init; } = id;
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string EmailAddress { get; set; } = emailAddress;
    public string? PhoneNumber { get; set; } = phoneNumber;


}

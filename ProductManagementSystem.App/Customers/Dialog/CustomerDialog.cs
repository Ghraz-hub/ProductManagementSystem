using ProductManagementSystem.App.Customers.Services;

namespace ProductManagementSystem.App.Customers.Dialog;

public class CustomerDialog(ICustomerService customerService) : ICustomerDialog
{

    public void ShowDialog()
    {
        Console.Clear();
        Console.WriteLine("#### ADD CUSTOMER ####");
        InputDialog($"Enter first name: ", out string firstName);
        InputDialog($"Enter last name: ", out string lastName);
        InputDialog($"Enter email: ", out string email);
        InputDialog($"Enter phonenumber: ", out string phone);

        var customer = customerService.AddCustomer(firstName, lastName, email, phone);

        if (customer is not null)
            Console.WriteLine($"Customer with id '{customer.Id}' was created");
        else
            Console.WriteLine($"Unable to create new customer");

        Console.ReadKey();

    }
    public void ShowAllCustomers()
    {
        var customers = customerService.GetAllCustomers();

        foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.FullName}");
        }
    }

    private static void InputDialog(string text, out string value)
    {
        do
        {
            Console.Write($"{text}");
            value = Console.ReadLine() ?? string.Empty;
            Console.Clear();
               
        }
        while(string.IsNullOrWhiteSpace(text));

    }
}

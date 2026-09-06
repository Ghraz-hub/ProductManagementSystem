using ProductManagementSystem.App.Suppliers.Services;

namespace ProductManagementSystem.App.Suppliers.Dialog;

public class SupplierDialog(ISupplierService supplierService) : ISupplierDialog
{
    public void ShowSupplierDialog()
    {
        Console.WriteLine("### ADD SUPPLIER ###");
        InputDialog("Enter name of supplier: ", out string name);
        InputDialog("Enter location of supplier: ", out string location);
        InputDialog("Enter phone number of supplier: ", out string? phoneNumber);
        InputDialog("Enter email of supplier: ", out string email);
        InputDialog("Enter buissnessnumber of supplier: ", out string buissnessNumber);

        var supplier = supplierService.CreateSupplier(name, location, buissnessNumber, email, phoneNumber);

        Console.WriteLine($"Supplier '{supplier.Name}' successfully added!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
    public void ShowAllSuppliers()
    {
        var suppliers = supplierService.GetSuppliers();
        Console.WriteLine("### SUPPLIERS ###");
        foreach (var item in suppliers)
        {
            Console.WriteLine($"{item}");
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    private static void InputDialog(string text, out string value)
    {
        do
        {
            Console.Write($"{text}");
            value = Console.ReadLine() ?? string.Empty;
            Console.Clear();
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("You must write someting to continue!");
            }
        }
        while(string.IsNullOrWhiteSpace(value));
    }
}

using ProductManagementSystem.App.Products.Services;

namespace ProductManagementSystem.App.Products.Dialog;

public class ProductDialog(IProductService productService) : IProductDialog
{
    public void ShowProductDialog()
    {
        Console.WriteLine($"#### ADD PRODUCT ####");
        InputDialog($"Enter the name of the product: ", out string name);
        InputDialog($"Enter the price of the product: ", out string price);
        InputDialog($"Enter the quantity of the product: ", out string quantity);

        var product = productService.CreateProduct(name, price, quantity);

        Console.WriteLine($"Product '{product.Name}' was successfully added.");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();

    }
    public void ShowAllProducts()
    {
        var products = productService.GetAllProducts();

        Console.WriteLine($"#### PRODUCTLIST ####");
        foreach (var item in products)
        {
            Console.WriteLine($"Name : {item.Name}");
            Console.WriteLine($"Price : {item.Price}kr");
            Console.WriteLine($"Quantity : {item.Quantity}st");
            Console.WriteLine($"Logged : {item.Logged}");
            Console.WriteLine("-----------------------");
        }
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
        }
        while(string.IsNullOrWhiteSpace(value));
    }
}

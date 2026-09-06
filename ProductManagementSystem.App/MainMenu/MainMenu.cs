using ProductManagementSystem.App.Customers.Dialog;
using ProductManagementSystem.App.Products.Dialog;
using ProductManagementSystem.App.Suppliers.Dialog;

namespace ProductManagementSystem.App.MainMenu;

public class MainMenu(ICustomerDialog customerDialog, IProductDialog productDialog, ISupplierDialog supplierDialog)
{
    private bool _isRunning = true;
    public void ShowMainMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine($"#### MAINMENU ####");
            Console.WriteLine("[1] CUSTOMERS ");
            Console.WriteLine("[2] PRODUCTS ");
            Console.WriteLine("[3] SUPPLIER ");
            Console.WriteLine("[0] QUIT ");

            var input = Console.ReadLine();

            switch( input)
            {
                case "1":
                    customerDialog.ShowCustomerDialog();
                    customerDialog.ShowAllCustomers();
                    break;
                case "2":
                    productDialog.ShowProductDialog();
                    productDialog.ShowAllProducts();
                    break;
                case "3":
                    supplierDialog.ShowSupplierDialog();
                    supplierDialog.ShowAllSuppliers();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You must enter a valid option!");
                    Console.ReadKey();
                    break;
            }
        }
        while (_isRunning);
    }
}

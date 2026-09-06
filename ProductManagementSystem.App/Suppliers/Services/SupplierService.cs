using ProductManagementSystem.App.Suppliers.Models;

namespace ProductManagementSystem.App.Suppliers.Services;

public class SupplierService : ISupplierService
{
    private readonly List<Supplier> _supplierList = [];
    public Supplier CreateSupplier(string supplierName, string Location, string BuissnessNumber, string Email, string? PhoneNumber = null)
    {
        var supplier = new Supplier(supplierName, Location, BuissnessNumber, Email, PhoneNumber);

        return supplier;
    }

    public List<Supplier> GetSuppliers()
    {
        return _supplierList;
    }
}

using ProductManagementSystem.App.Suppliers.Models;

namespace ProductManagementSystem.App.Suppliers.Services;

public interface ISupplierService
{
    public Supplier CreateSupplier(string  supplierName, string Location, string BuissnessNumber, string Email, string? PhoneNumber = null);

    public List<Supplier> GetSuppliers();
}

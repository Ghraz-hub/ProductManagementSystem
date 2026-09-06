using ProductManagementSystem.App.Products.Models;

namespace ProductManagementSystem.App.Products.Services;

public interface IProductService
{
    public Product CreateProduct(string name, string price, string quantity);

    public List<Product> GetAllProducts(); 
}

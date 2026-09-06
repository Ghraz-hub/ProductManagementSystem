using ProductManagementSystem.App.Products.Models;

namespace ProductManagementSystem.App.Products.Services;

public interface IProductService
{
    public Product CreateProduct(string name, decimal price, int quantity);

    public List<Product> GetAllProducts(List<Product> products); 
}

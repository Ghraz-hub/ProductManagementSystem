using ProductManagementSystem.App.Products.Models;

namespace ProductManagementSystem.App.Products.Services;

internal class ProductService : IProductService
{
    private readonly List<Product> _productList = [];
    public Product CreateProduct(string name, decimal price, int quantity)
    {
        var logged = DateTime.Now;

        var newProduct = new Product(name, price, quantity, logged);

        _productList.Add(newProduct);

        return newProduct;
    }

    public List<Product> GetAllProducts(List<Product> products)
    {
        return _productList;
    }
}

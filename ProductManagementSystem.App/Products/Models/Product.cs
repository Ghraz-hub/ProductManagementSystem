namespace ProductManagementSystem.App.Products.Models;

public class Product(string name, decimal price, int quantity, DateTime logged)
{
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;
    public int Quantity { get; set; } = quantity;
    public DateTime Logged { get; set; } = logged;
}

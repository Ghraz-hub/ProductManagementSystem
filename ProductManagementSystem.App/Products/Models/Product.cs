namespace ProductManagementSystem.App.Products.Models;

public class Product(string name, string price, string quantity, DateTime? logged)
{
    public string Name { get; set; } = name;
    public string Price { get; set; } = price;
    public string Quantity { get; set; } = quantity;
    public DateTime? Logged { get; init; } = logged;
}

namespace ProductManagementSystem.App.Suppliers.Models;

public record Supplier
(
    string Name,
    string Location,
    string BuissnessNumber,
    string Email,
    string? PhoneNumber = null
);

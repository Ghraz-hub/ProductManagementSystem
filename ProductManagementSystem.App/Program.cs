using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductManagementSystem.App.Customers.Dialog;
using ProductManagementSystem.App.Customers.Services;
using ProductManagementSystem.App.MainMenu;
using ProductManagementSystem.App.Products.Dialog;
using ProductManagementSystem.App.Products.Services;
using ProductManagementSystem.App.Suppliers.Dialog;
using ProductManagementSystem.App.Suppliers.Services;

var builder = Host.CreateApplicationBuilder(args);

// Customer
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddTransient<ICustomerDialog, CustomerDialog>();

// Product
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddTransient<IProductDialog, ProductDialog>();

// Supplier

builder.Services.AddSingleton<ISupplierService, SupplierService>();
builder.Services.AddTransient<ISupplierDialog, SupplierDialog>();

// Bygg EFTER att allt registrerats
using var host = builder.Build();

var dialogCustomer = host.Services.GetRequiredService<ICustomerDialog>();

var dialogProduct = host.Services.GetRequiredService<IProductDialog>();

var dialogSupplier = host.Services.GetRequiredService<ISupplierDialog>();

var mainMenu = new MainMenu(dialogCustomer, dialogProduct, dialogSupplier);

mainMenu.ShowMainMenu();


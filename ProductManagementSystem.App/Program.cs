using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductManagementSystem.App.Customers.Dialog;
using ProductManagementSystem.App.Customers.Services;
using ProductManagementSystem.App.Products.Dialog;
using ProductManagementSystem.App.Products.Services;

var builder = Host.CreateApplicationBuilder(args);

// Customer
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddTransient<ICustomerDialog, CustomerDialog>();

// Product
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddTransient<IProductDialog, ProductDialog>();

// Bygg EFTER att allt registrerats
using var host = builder.Build();

var dialogCustomer = host.Services.GetRequiredService<ICustomerDialog>();

dialogCustomer.ShowCustomerDialog();
dialogCustomer.ShowAllCustomers();

var dialogProduct = host.Services.GetRequiredService<IProductDialog>();

dialogProduct.ShowProductDialog();
dialogProduct.ShowAllProducts();
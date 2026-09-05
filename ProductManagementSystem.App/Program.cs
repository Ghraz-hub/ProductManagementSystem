using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductManagementSystem.App.Customers.Dialog;
using ProductManagementSystem.App.Customers.Services;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddTransient<ICustomerDialog, CustomerDialog>();

using var host = builder.Build();

var dialog = host.Services.GetRequiredService<ICustomerDialog>();

dialog.ShowDialog();
dialog.ShowAllCustomers();
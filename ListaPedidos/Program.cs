// See https://aka.ms/new-console-template for more information
using System.Globalization;
using ListaPedidos.entities;
using ListaPedidos.entities.enums;

Console.WriteLine("Enter cliente data:");
Console.Write("Name: ");
string? name = Console.ReadLine();
Console.Write("Email: ");
string? email = Console.ReadLine();
Console.Write("BirthDate: ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(name,email,birthDate);
Order order = new Order(DateTime.Now,status,client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
  Console.WriteLine($"Enter #{i} item data:");
  Console.Write("Product name: ");
  string? productName = Console.ReadLine();
  Console.Write("Product price: ");
  double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
  Console.Write("Quantity: ");
  int quantity = int.Parse(Console.ReadLine());

  Product product = new Product(productName,price);

  order.Add(new OrderItem(quantity,price,product));
}

Console.WriteLine(order);
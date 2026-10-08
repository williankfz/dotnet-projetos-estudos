// See https://aka.ms/new-console-template for more information
using System.Globalization;
using ListaProdutos.entities;

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();

for(int i = 1; i <= n; i++)
{
  Console.WriteLine($"Product #{i} data:");
  Console.Write("Common, used or imported (c/u/i)? ");
  char res = char.Parse(Console.ReadLine());
  Console.Write("Name: ");
  string? name = Console.ReadLine();
  Console.Write("Price: ");
  double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

  if(res == 'i')
  {
    Console.Write("Customs fee: ");
    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

    products.Add(new ImportedProduct(name,price,customsFee));
  }else if(res == 'u')
  {
    Console.Write("Manufacture date (DD/MM/YYYY): ");
    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

    products.Add(new UsedProduct(name,price,manufactureDate));
  }
  else
  {
    products.Add(new Product(name,price));
  }
}

Console.WriteLine("PRICE TAGS:");
foreach(var item in products)
{
  Console.WriteLine(item.PriceTag());
}

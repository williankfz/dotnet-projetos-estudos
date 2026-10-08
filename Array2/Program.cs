// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Array2;

int n = int.Parse(Console.ReadLine());

Produto[] prod = new Produto[n];

double total = 0.0;

for(int i = 0; i < n; i++)
{
  string? nome = Console.ReadLine();
  double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
  
  prod[i] = new Produto(nome,preco);

  total += prod[i].Preco / n;
}

Console.WriteLine($"AVERAGE PRICE = {total.ToString("F2",CultureInfo.InvariantCulture)}");

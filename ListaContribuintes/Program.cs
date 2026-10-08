// See https://aka.ms/new-console-template for more information
using System.Globalization;
using ListaContribuintes.entities;

Console.Write("Enter the number of tax payers:");
int n = int.Parse(Console.ReadLine());

List<TaxPayer> taxPayers = new List<TaxPayer>();

for(int i = 1; i <= n; i++)
{
  Console.WriteLine($"Tax payer #{i} data:");
  Console.Write("Individual or company (i/c)? ");
  char res = char.Parse(Console.ReadLine());
  Console.Write("Name: ");
  string? name = Console.ReadLine();
  Console.Write("Anual Income: ");
  double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

  if(res == 'i')
  {
    Console.Write("Health expenditures: ");
    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    taxPayers.Add(new Individual(name,anualIncome,healthExpenditures));
  }
  else
  {
    Console.Write("Number of employees: ");
    int numberOfEmployee = int.Parse(Console.ReadLine());
    taxPayers.Add(new Company(name,anualIncome,numberOfEmployee));
  }
}

Console.WriteLine("TAXES PAID:");
double total = 0.0;
foreach(var item in taxPayers)
{
  total += item.Tax();
  Console.WriteLine($"{item.Name}: ${item.Tax().ToString("F2",CultureInfo.InvariantCulture)}");
}

Console.WriteLine($"TOTAL TAXES: $ {total.ToString("F2",CultureInfo.InvariantCulture)}");
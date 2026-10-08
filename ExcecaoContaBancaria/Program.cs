// See https://aka.ms/new-console-template for more information
using System.Globalization;
using ExcecaoContaBancaria.entities;
using ExcecaoContaBancaria.entities.Exceptions;

try
{
Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string? holder = Console.ReadLine();
Console.Write("Initial balance: ");
double initialBalance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Account acc = new Account(number,holder,initialBalance,withdrawLimit);

Console.Write("Enter amount for withdraw: ");
double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

acc.Withdraw(amount);

Console.WriteLine($"New Balance: {acc.Balance}");
}
catch (DomainException e)
{
  Console.WriteLine(e.Message);
}

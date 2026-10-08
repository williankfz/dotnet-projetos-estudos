// See https://aka.ms/new-console-template for more information

using System.Globalization;
using ContaBancaria.entities;

Conta conta;

Console.Write("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string? titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char res = char.Parse(Console.ReadLine());

if(res == 's')
{
  Console.Write("Entre o valor de depósito inicial: ");
  double valorInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
  conta = new Conta(numero,titular,valorInicial);
}
else
{
  conta = new Conta(numero,titular);
}

Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);

Console.Write("Entre um valor para depósito: ");
double novoValor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

conta.Deposito(novoValor);


Console.WriteLine("Dados da conta atualizado: ");
Console.WriteLine(conta);

Console.Write("Entre um valor para saque: ");
novoValor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

conta.Saque(novoValor);

Console.WriteLine("Dados da conta atualizado: ");
Console.WriteLine(conta);
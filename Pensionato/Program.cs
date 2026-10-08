// See https://aka.ms/new-console-template for more information
using Pensionato.Entities;

Console.Write("Quantos quartos serão alugados? ");
int n = int.Parse(Console.ReadLine());

Aluguel[] aluguels = new Aluguel[10];

for(int i = 1; i <= n; i++)
{
  Console.WriteLine($"Aluguel #{i}");
  Console.Write("Nome: ");
  string? nome = Console.ReadLine();
  Console.Write("Email: ");
  string? email = Console.ReadLine();
  Console.Write("Quarto: ");
  int quarto = int.Parse(Console.ReadLine());
  aluguels[quarto] = new Aluguel(nome,email);
}

Console.WriteLine("Quartos ocupados:");
for(int i = 0; i < 10; i++)
{
  if(aluguels[i] != null)
  {
    Console.WriteLine($"{i}: {aluguels[i].Nome}. {aluguels[i].Email}");
  }
}
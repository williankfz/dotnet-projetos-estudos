// See https://aka.ms/new-console-template for more information
using System.Globalization;
using ProdutoEstoque.entities;

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
string? nome = Console.ReadLine();
Console.Write("Preco: ");
double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Quantidade:");
int quantidade = int.Parse(Console.ReadLine());

Produto produto = new Produto(nome,preco,quantidade);

Console.WriteLine($"Dados do produto: {produto}");

Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
int novaQuantidade = int.Parse(Console.ReadLine());

produto.Adicionar(novaQuantidade);

Console.WriteLine($"Dados atualizado: {produto}");

Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
novaQuantidade = int.Parse(Console.ReadLine());

produto.Remover(novaQuantidade);

Console.WriteLine($"Dados atualizado: {produto}");
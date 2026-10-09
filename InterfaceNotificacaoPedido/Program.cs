// See https://aka.ms/new-console-template for more information
using InterfaceNotificacaoPedido.Entities;
using InterfaceNotificacaoPedido.Services;

Console.WriteLine("Digite seu nome: ");
string? nome = Console.ReadLine();

Pedido pedido1 = new Pedido(nome,new EmailNotificador());

Console.WriteLine(pedido1.Finalizar());

Pedido pedido2 = new Pedido(nome, new SmsNotificador());

Console.WriteLine(pedido2.Finalizar());
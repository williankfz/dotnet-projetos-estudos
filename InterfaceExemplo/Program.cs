// See https://aka.ms/new-console-template for more information
using InterfaceExemplo.entities;
using InterfaceExemplo.services;

List <IPagamento> formas = new List<IPagamento>
{
  new CartaoCredito(),
  new Pix(),
  new Boleto()
};

foreach(var forma in formas)
{
  forma.Processar(150.00m);
}

var pedido = new Pedido(new Pix(), 200m);

//Passando para um método
FinalizarCompra(new Pix(), 80m);

static void FinalizarCompra(IPagamento pagamento, decimal valor)
{
  Console.WriteLine("Finalizando compra...");
  pagamento.Processar(valor);
}

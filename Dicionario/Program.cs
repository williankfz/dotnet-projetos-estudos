// See https://aka.ms/new-console-template for more information
//Método ADD
Dictionary<int,string> dic1 = new Dictionary<int,string>();

dic1.Add(1,"Maria");
dic1.Add(2,"Paulo");
dic1.Add(3,"Pedro");

foreach(var item in dic1)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

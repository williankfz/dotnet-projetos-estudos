// See https://aka.ms/new-console-template for more information
using System.Globalization;
using ListaFuncionarios.entities;

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());

List<Funcionario> func = new List<Funcionario>();

for(int i = 1; i <= n; i++)
{
  Console.WriteLine($"Employee #{i}");
  Console.Write("Id: ");
  int id = int.Parse(Console.ReadLine());
  Console.Write("Name: ");
  string? name = Console.ReadLine();
  Console.Write("Salary: ");
  double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

  func.Add(new Funcionario(id,name,salary));

}


Console.Write("Enter the employee id that will have salary increase: ");
int searchId = int.Parse(Console.ReadLine());

Funcionario funcionario = func.Find(x => x.Id == searchId);

if(funcionario != null)
{
  Console.Write("Enter the percentage: ");
  double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
  funcionario.IncreaseSalary(percentage);
}
else
{
  Console.WriteLine("This id does not exist!");
}

foreach(var item in func)
{
  Console.WriteLine(item);
}
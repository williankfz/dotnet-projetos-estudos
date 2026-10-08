// See https://aka.ms/new-console-template for more information
using System.Globalization;

int n = int.Parse(Console.ReadLine());

double[] height = new double[n];

double total = 0.0;

for(int i = 0; i < n; i++)
{
  height[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

  total += height[i] / n;
}

Console.WriteLine($"AVERAGE HEIGHT = {total.ToString("F2",CultureInfo.InvariantCulture)}");

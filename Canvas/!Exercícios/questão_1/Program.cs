using System;
using System.Diagnostics;

#pragma warning disable CA1050 // Declare types in namespaces
public class Program
{

    public static void Main()
    {
        Double b, h;

        Console.Write("Infome o valor da base do retângulo: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor da altura do retângulo: ");
        h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"O valor do perímetro desse retângulo é {2*(b+h)}");
        Console.WriteLine($"O valor da área desse retângulo é {b*h}");
        Console.WriteLine($"O valor da diagonal desse retângulo é {Math.Sqrt(Math.Pow(b, 2)+Math.Pow(h, 2))}");
    }

}
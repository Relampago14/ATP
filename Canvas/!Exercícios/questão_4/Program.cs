using System;

public class Program{

    public static void Main(){

        double x1, y1, x2, y2;

        Console.Write("Insira a coordenada X1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira a coordenada Y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira a coordenada X2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira a coordenada Y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write($"A distância entre P({x1}, {y1}) e P({x2}, {y2}) é {Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2))}");

    }

}
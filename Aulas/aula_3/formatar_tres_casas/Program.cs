using System;

class Program{

    public static void Main(){

        double v;

        Console.Write("Escreva um valor: ");
        v = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{v:F3}");

    }

}
using System;

public class Program{
    public static void Main(){

        Double c1, c2;

        Console.Write("Escreva o valor de um cateto do triângulo retângulo: ");
        c1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escreva o valor do outro cateto do triângulo retângulo: ");
        c2 = Convert.ToDouble(Console.ReadLine());

        Console.Write($"A hipotenusa desse triângulo retângulo vale {Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2))}");

    }
}
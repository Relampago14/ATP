using System;

public class Program{

    public static void Main(){

        double A, B, C;

        Console.WriteLine("Insira o valor de A:");
        A = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o valor de B:");
        B = Convert.ToDouble(Console.ReadLine());

        C = A;
        A = B;
        B = C;

        Console.WriteLine($"O valor final de A é {A}");
        Console.WriteLine($"O valor final de B é {B}");

    }

}
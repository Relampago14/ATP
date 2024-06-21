using System;

public class Program{
    public static void Main(){

        double l_caixa, b_caixa;

        Console.WriteLine("Escreva o valor do lado da caixa d'água: ");
        l_caixa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escreva o valor da base da caixa d'água: ");
        b_caixa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"O valor da base é {l_caixa} e o da base é {b_caixa}");
        Console.WriteLine($"Portanto o volume é {l_caixa * b_caixa / 3}");

    }
}
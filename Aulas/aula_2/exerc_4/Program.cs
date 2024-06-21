using System;

class Program{
    public static void Main(){

        // Comprimento em metros
        double length_arame, side_quadrado;

        Console.WriteLine("Digite o valor em metros do comprimeto do arame: ");
        length_arame = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(((length_arame/4)*2)+" m².");

        side_quadrado = length_arame / 4;

        Console.WriteLine($"O comprimento do arame é: {length_arame} metros.");
        Console.WriteLine($"O comprimento do lado do quadrado é: {side_quadrado} metros.");
        Console.WriteLine($"A área desse quadrado é: {side_quadrado * side_quadrado} m².");

    }
}
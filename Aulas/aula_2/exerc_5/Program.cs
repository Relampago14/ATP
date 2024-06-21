using System;

public class Program{
    public static void Main(string[] args){
        
        double l_caixa, volume_caixa;

        Console.WriteLine("Insira o lado da caixa d'água quadrada: ");
        l_caixa = Convert.ToDouble(Console.ReadLine());

        volume_caixa = Math.Pow(l_caixa,3);

        Console.WriteLine($"O lado da caixa d'água é {l_caixa} metros, e o volume dela é {volume_caixa} m³.");

    }
}
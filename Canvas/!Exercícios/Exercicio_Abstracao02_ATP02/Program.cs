using System;

class Program{

    public static void Main(){

        // Imprime pedindo um valor
        Console.WriteLine("Digite um valor em metros: ");
        Converter.showResults(Converter.verifNum((Console.ReadLine())));

    }

}

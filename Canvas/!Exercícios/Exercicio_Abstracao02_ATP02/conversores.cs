using System;

class Converter{

    public static double convertMili(double m){

        // Converte os metros recebidos em milímetros e retorna o valor
        return m * 1000;

    }

    public static double convertCenti(double m){

        // Converte os metros recebidos em centímetros e retorna o valor
        return m * 100;

    }  

    public static double convertKi(double m){

        // Converte os metros recebidos em quilômetros e retorna o valor
        return m / 1000;


    }

    public static int verifNum(string str_num){

    // Pega a string recebida e somente irá liberar caso a mesma possa ser convertida para inteiro

    int int_num;

    while (!(int.TryParse(str_num, out int_num))){

        Console.WriteLine("Por favor, digite um número: ");
        str_num = Console.ReadLine();

    }

    return int_num;

    }

    public static void showResults(double m){

        // Escreve os resultados ao passo que chama as funções de conversão
        Console.WriteLine("Os resultados das conversões são: ");
        Console.WriteLine($"{m} metros = {convertMili(m)} milímetros.");
        Console.WriteLine($"{m} metros = {convertCenti(m)} centímetros.");
        Console.WriteLine($"{m} metros = {convertKi(m)} quilômetros.");

    }

}
using System;

class Program{

    static string[] marca = new string[5];
    static string[] modelo = new string[5];
    static double[] preco = new double[5];
    static int[] ano = new int[5];
    static int[] cc = new int[5];

    public static void Main(){

        marca[0] = "teste 1";
        marca[1] = "teste 2";

        Console.WriteLine(marca[0]);
        Console.WriteLine(marca.Length);

    }

}
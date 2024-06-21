using System;

class Program{

    public static void Main(){

        int n = 1;
        int n_ant = 2;

        while (n<101){

            n += n_ant;
            n_ant++;

        }

        Console.WriteLine($"A soma é {n}");

    }

}
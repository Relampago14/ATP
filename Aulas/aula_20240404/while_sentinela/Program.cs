using System;

class Program{

    public static void Main(){

        int valor = 1;

        while (valor != 0){

            Console.WriteLine("Informe um valor numerico diferente inteiro [0 para terminar: ]");
            valor = Convert.ToInt32(Console.ReadLine());

        }

}

}
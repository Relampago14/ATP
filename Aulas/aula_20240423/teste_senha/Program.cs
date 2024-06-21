using System;

class Program{

    public static void Main(){

        int a = 0, senha = 123;

        do {

            Console.Write("Informe a senha numérica: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a != senha){

                Console.WriteLine("Senha errada, tente novamente!!!");

            }
         
        } while (a != senha);

        Console.WriteLine("Acertou!!!");
    }

}
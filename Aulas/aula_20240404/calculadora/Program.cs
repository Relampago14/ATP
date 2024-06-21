using System;

class Program{

    public static void Main(){

        double n1, n2;
        int operacao = 0;

        while (operacao != 3){

            Console.Write("Digite 1 para soma, 2 para subtração e 3 para sair do programa: ");
            operacao = Convert.ToInt32(Console.ReadLine());

            if (operacao == 3){
                continue;
            }

            Console.Write("Escreva um valor: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escreva outro valor: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            switch(operacao){

                case 1:Console.WriteLine($"A soma entre {n1} e {n2} é: {n1 + n2}."); break;
                case 2:Console.WriteLine($"A subtração entre {n1} e {n2} é: {n1 - n2}."); break;
                case 3:Console.WriteLine($"Programa encerrado."); break;
                default:Console.WriteLine("Valor inválido."); break;

            }

        }

        Console.WriteLine($"Programa encerrado.");

    }

}
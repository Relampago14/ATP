using System;

class Program{

    public static void Main(){

        // Declara as variáveis inteiras "n1", para receber o primeiro valor;
        // "n1_aux", para manter esse primeiro valor inalterado e auxiliar na saída do programa;
        // "n2", para receber o segundo número
        int n1, n1_aux, n2;

        // Imprime na tela solicitando ao usuário que digite um número
        Console.Write("Digite um número: ");

        // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena em "n1"
        n1 = Convert.ToInt32(Console.ReadLine());

        // Iguala "n1_aux" à "n1"
        n1_aux = n1;

        // Imprime na tela solicitando ao usuário que digite um número
        Console.Write($"Digite outro número menor que {n1}: ");

        // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena em "n2"
        n2 = Convert.ToInt32(Console.ReadLine());

        // Enquanto "n2" for maior ou igual a "n1", executa o bloco abaixo
        while (n2 >= n1){

            // Imprime na tela solicitando ao usuário que digite um número corretamente
            Console.Write($"{n2} não é maior que {n1}. Por favor, digite um número menor que {n1}: ");

            // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena em "n2"
            n2 = Convert.ToInt32(Console.ReadLine());

        }

        // Executa o bloco abaixo ...
        do{

            // Decrementa o valor de "n2" de uma unidade, como pede o enunciado
            n2--;

            // Incrementa o valor de "n1" em uma unidade, como pede o enunciado
            n1 += 1;

        } while (n2 > 0); //... enquanto "n2" for maior que zero

        // Imprime na tela os dois valores recebidos e a diferença entre eles
        Console.Write($"A diferença entre {n1_aux} e {n2 + (n1 - n1_aux)} é igual a {n1 - n1_aux}.");
    }

}

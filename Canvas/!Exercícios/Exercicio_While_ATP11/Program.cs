using System;

class Program{

    public static void Main(){

        // Declaração das variáveis inteiras a serem comparadas
        int n1, n2;
        
        // Imprime na tela pedindo que o usuário digite o primeiro número inteiro
        Console.Write("Digite um número inteiro: ");

        // Recebe o valor digitado pelo usuário, converte para inteiro de 32 bits e armazena na variável n1
        n1 = Convert.ToInt32(Console.ReadLine());

        // Imprime na tela pedindo que o usuário digite o segundo número inteiro
        Console.Write($"Agora digite outro número inteiro maior que {n1}: ");

        // Recebe o valor digitado pelo usuário, converte para inteiro de 32 bits e armazena na variável n2
        n2 = Convert.ToInt32(Console.ReadLine());

        // Enquanto a varíavel n2 for menor que n1, executa o bloco abaixo
        while (n2 < n1){

            // Imprime na tela pedindo ao usuário que digite novamente, porém um número maior que n1
            Console.Write($"Por favor, digite um número maior que {n1}: ");

            // Recebe o valor digitado pelo usuário, converte para inteiro de 32 bits e armazena na variável n2
            n2 = Convert.ToInt32(Console.ReadLine());

        }

        // Imprime na tela exibindo o valor de n1 e n2, mostrando que n2 é maior que n1
        Console.Write($"O primeiro valor digitado {n1} é menor que o segundo valor digitado {n2}.");

    }

}
using System;

class Program{

    public static void Main(){

        // Declara as variáveis inteiras "n", para determinar o número a ser calculado o fatorial
        // e "fatorial", para armazenar o valor do fatorial
        int n, fatorial;

        // Imprime na tela pedindo ao usuário que digite um número natural para ser calculado o fatorial
        Console.Write("Digite um número natural para calcular o fatorial: ");

        // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena na variável "n"
        n = Convert.ToInt32(Console.ReadLine());
        
        // Enquanto "n" for menor que zero, executa o bloco abaixo
        while (n<0){

            // Imprime na tela pedindo ao usuário que digite um número natural para ser calculado o fatorial
            Console.Write("Por favor, digite um número maior ou igual à zero para calcular o fatorial: ");

            // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena na variável "n"
            n = Convert.ToInt32(Console.ReadLine());

        }

        // A variável "fatorial" recebe o valor da variável "n"
        fatorial = n;

        // Se "fatorial" for diferente de zero, executa o bloco abaixo
        if (fatorial != 0){

            // Para cada vez que "i" for menor que "n", executa o bloco abaixo, sendo que "i" é um inteiro,
            // inicia com valor igual a um e a cada execução, soma-se mais uma unidade ao valor de "i"
            for (int i = 1; i < n; i++){

                // A variável "fatorial" recebe o valor dela mesma vezes a variável "i"
                fatorial *= i;

            }

            // Imprime na tela o valor digitado e seu respectivo fatorial
            Console.Write($"O fatorial de {n} é igual a: {fatorial}.");

        }

        // Se "fatorial" for igual a zero, executa o bloco abaixo
        if (fatorial == 0){

            // Imprime na tela o valor digitado e seu respectivo fatorial
            Console.Write($"O fatorial de {n} é igual a: {fatorial + 1}.");

        }

    }

}
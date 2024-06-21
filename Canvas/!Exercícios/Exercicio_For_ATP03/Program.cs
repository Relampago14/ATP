using System;

class Program{

    public static void Main(){

        // Declara duas variáveis inteiras, n para armazenar quantos números a serem somados,
        // soma para armazenar a soma entre os números e nat para validar se o número é natural ou não
        int n = 0, soma = 0;
        bool nat = true;

        // Imprime na tela pedindo ao usuário que digite um número
        Console.Write("Digite um número para definir quantos números naturais a serem somados: ");

        // Recebe o valor que o usuário digitar, converte para int de 32 bits e armazena em n
        n = Convert.ToInt32(Console.ReadLine());
        
        // Se n for menor do que zero, executa o bloco abaixo
        if (n < 0){

            // A variável Booleana nat recebe valor lógico falso
            nat = false;

        }

        // Enquanto nat for falsa, executa o bloco abaixo
        while (!nat)
        {

            // Imprime na tela pedindo ao usuário que digite um número
            Console.Write($"O número {n} não é natural. Digite outro número que seja natural: ");

            // Recebe o valor que o usuário digitar, converte para int de 32 bits e armazena em n
            n = Convert.ToInt32(Console.ReadLine());

            // Se n for maior ou igual a zero, executa o bloco abaixo
            if (n >= 0){

                // A variável Booleana nat recebe valor lógico verdadeiro
                nat = true;

            }

        }

        // Para cada vez que o i for menor que n, executa o bloco abaixo. 
        // A varíavel i começa igual a zero e vai iterando em uma unidade a cada execução
        for(int i = 0; i <= n; i++){

            // Se n for maior que 1, executa o bloco abaixo
            if (n > 1){

                // A avariável soma é acrescentada da variável i
                soma += i;

            }

        }

        // Imprime na tela o valor solicitado para soma e de fato a soma
        Console.Write($"A soma dos {n} primeiros números naturais é {soma}.");

    }

}
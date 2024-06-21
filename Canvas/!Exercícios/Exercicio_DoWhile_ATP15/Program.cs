using System;

class Program
{

    public static void Main()
    {

        // Declara as variáveis inteiras "n1", para receber o valor do fatorial a ser calculado;
        // "n1_aux", para armazenar o valor solicitado e mantê-lo inalterado;
        // "n2" para complementar o cálculo do fatorial; 
        // "acc" para receber o valor da multiplicação entre n1 e n2; "fatorial", para receber o fatorial e
        // posteriormente o dobro desse valor
        int n1, n1_aux, n2, acc, fatorial = 1;

        // Imprime na tela pedindo que o usuário digite um número
        Console.Write("Digite um número natural para calcular o dobro do fatorial: ");

        // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena na variável "n1"
        n1 = Convert.ToInt32(Console.ReadLine());

        // Enquanto "n1" for menor do que zero, executa o bloco abaixo
        while (n1 < 0)
        {

            // Imprime na tela pedindo que o usuário digite um número
            Console.Write($"{n1} não é um número natural, por favor, digite um número para calcular " +
            "o dobro do fatorial: ");

            // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena na variável "n1"
            n1 = Convert.ToInt32(Console.ReadLine());

        }

        // A variável "n1_aux" recebe o valor de "n1"
        n1_aux = n1;

        // Se "n1" for maior do que um, executa o bloco abaixo
        if (n1 > 1){
            
            // Execute o bloco abaixo...
            do
            {

                // "n2" recebe o valor de "n1" menos um
                n2 = n1 - 1;

                // "acc" recebe a multiplicação entre "n1" e "n2"
                acc = n1 * n2;

                // "fatorial" recebe o valor dele mesmo multiplicado de "acc"
                fatorial *= acc;

                // "n1" recebe o valor de "n2"
                n1 = n2;

                // Para passarmos pros próximos dois números (ou não), subtraímos "n1" de um
                n1--;

            } while (n1 > 1); //... enquanto "n1" for maior do que um
        }

        // "fatorial" recebe o dobro do seu valor
        fatorial *= 2;

        // Imprime na tela o dobro do fatorial do número solicitado
        Console.Write($"O dobro do fatorial de {n1_aux} é: {fatorial}");

    }

}
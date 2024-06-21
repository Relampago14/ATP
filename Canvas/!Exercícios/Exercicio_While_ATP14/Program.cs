using System;

class Program{

    public static void Main(){

        // Declara as variáveis n_1 e n_2 para serem comparadas, e a variável c para receber o valor da diferença
        // entre elas
        int n_1, n_2, c = 0;

        // Imprime na tela pedindo ao usuário que digite um valor
        Console.Write("Digite um valor: ");

        // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena na variavel n_1
        n_1 = Convert.ToInt32(Console.ReadLine());

        // Imprime na tela pedindo ao usuário que digite um outro valor
        Console.Write($"Digite outro valor: ");

        // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena na variavel n_2
        n_2 = Convert.ToInt32(Console.ReadLine());

        // Se n_1 for maior que n_2, executa o bloco abaixo
        if (n_1 > n_2){

            // Enquanto n_1 for maior que n_2, executa o bloco abaixo
            while (n_1 > n_2){

                // Soma n_2 em mais um, visando alcançar o valor de n_1
                n_2 += 1;

                // Adiciona mais um a cada vez que o valor acima é somado, para calcular a diferença
                c += 1;
            }
        }

        // Se n_1 for menor que n_2, executa o bloco abaixo
        if (n_1 < n_2){

            // Enquanto n_1 for menor que n_2, executa o bloco abaixo
            while (n_1 < n_2){
                
                // Soma n_1 em mais um, visando alcançar o valor de n_2
                n_1 += 1;

                // Adiciona mais um a cada vez que o valor acima é somado, para calcular a diferença
                c += 1;
            }
            
        }

        // Imprime na tela o valor de n_1, n_2 menos c e, na sequência, c
        Console.Write($"A diferença entre {n_1} e {n_2 - c} é de {c}.");

    }

}
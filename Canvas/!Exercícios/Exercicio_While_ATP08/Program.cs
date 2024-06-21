using System;

class Program{

    public static void Main(){

        // Declaração das variáveis double: n_base e exp, para realizar os cálculos da exponenciação;
        // n_base_aux e exp_aux, para auxiliar na saída do programa
        double n_base, n_base_aux, exp, exp_aux;

        // Imprime na tela pedindo ao usuário que digite o número da base
        Console.Write("Digite o número da base: ");

        // Recebe o valor que o usuário digitou, converte para Double e armazena o valor em n_base
        n_base = Convert.ToDouble(Console.ReadLine());

        // Iguala n_base_aux ao n_base, para poder realizar o cálculo no loop While e também imprimir corretamente ao final do programa
        n_base_aux = n_base;

        // Imprime na tela pedindo ao usuário que digite o número do expoente
        Console.Write("Agora digite o número do expoente: ");

        // Recebe o valor que o usuário digitou, converte para Double e armazena o valor em exp
        exp = Convert.ToDouble(Console.ReadLine());

        // Iguala exp_aux ao exp, para poder imprimir ao final do programa
        exp_aux = exp;

        // Enquanto a variável exp for maior que 1, executa o bloco abaixo
        while (exp > 1){

            // A cada vez q o comando é executado, multiplica o n_base pelo n_base_aux
            n_base *= n_base_aux;
            
            // Subtrai 1 de exp para realizar a quantidade de multiplicações acima corretamente, visando o cálculo da exponenciação
            exp -= 1;

        }

        // Imprime na tela os valores pedidos anteriormente e o resultado
        Console.Write($"O número {n_base_aux} elevado à {exp_aux} é igual a: {n_base}.");

    }

}
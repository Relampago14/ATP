//6. Imprimir N Termos da Sequência Fibonacci

using System;
class Program {
  public static void Main () {

    // Declara as variáveis inteiras "n_sequência", para receber quantos números da sequência de fibonnaci
    // irão aparecer; "n_ant_1" e "n_ant_2" para receber os números momentâneos da sequência;
    // "n_atual" para receber o valor do número da sequência de fibonacci
    int n_sequencia, n_ant_1 = 0, n_ant_2 = 1, n_atual = 1;

    // Imprime na tela pedindo ao usuário que insira quantos números da sequência de fibonacci ele deseja imprimir
    Console.WriteLine("Insira um valor para iniciar a sequência: ");

    // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena em "n_sequencia"
    n_sequencia = Convert.ToInt32(Console.ReadLine());

    // Enquanto "n" for menor que zero, executa o bloco abaixo
    while (n_sequencia < 0){

        // Imprime na tela pedindo ao usuário que digite um número natural para ser calculado o fatorial
        Console.Write("Por favor, digite um número maior ou igual à zero: ");

        // Recebe o valor digitado pelo usuário, converte para int de 32 bits e armazena na variável "n_sequencia"
        n_sequencia = Convert.ToInt32(Console.ReadLine());

    }

    // Para cada vez que "i" for menor que "n_sequencia", executa o bloco abaixo, sendo que "i" é um inteiro,
    // inicia com valor igual a zero e a cada execução, soma-se mais uma unidade ao valor de "i"
    for (int i = 0; i < n_sequencia; i++) {
        
        // Se "i" for maior ou igual a um, executa o bloco abaixo
        if (i >= 1){

            // "n_atual" recebe "n_ant_1" somado à "n_ant_2"
            n_atual = n_ant_1 + n_ant_2;

            // "n_ant_1" recebe o valor de "n_ant_2", para continuar a sequência
            n_ant_1 = n_ant_2;

            // "n_ant_2" recebe o valor de "n_atual", também para continuar a sequência
            n_ant_2 = n_atual;

        }

        // Imprime na tela o número de acordo com sua colocação na sequência
        Console.WriteLine($"O {i + 1}° número da Sequência de Fibonacci é {n_atual}");

    }


    // Imprime na tela que o programa se encerrou
    Console.WriteLine("Programa encerrado.");

  }
}
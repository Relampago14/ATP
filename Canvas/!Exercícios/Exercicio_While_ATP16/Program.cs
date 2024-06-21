using System;

class Program{
  public static void Main (){

    // Declara as variáveis inteiras a serem usadas
    int n_sequencia = 0, n_sequencia_aux, n_ant_1 = 0, n_ant_2 = 1, n_atual = 0;

    // Imprime na tela pedindo ao usuário que digite quantos números da Sequência de Fibonnacci ele deseja somar
    Console.Write("Digite um valor inteiro, positivo e maior que zero " +
     "de quantos números da sequência de Fibonacci você deseja somar: ");

    // Recebe o valor digitado, converte para inteiro de 32 bits e armazena na variável n_sequencia
    n_sequencia = Convert.ToInt32(Console.ReadLine());

    while (n_sequencia < 1){

        Console.Write("Número inválido, por favor um valor inteiro e positivo e maior que zero: ");
        n_sequencia = Convert.ToInt32(Console.ReadLine());
        
    }

    // Armazena o valor de n_sequencia em n_sequencia_aux para auxiliar na saída do programa após o loopcwhile abaixo
    n_sequencia_aux = n_sequencia;

    // Enquanto a  variável n_sequencia for maior do que zero, executa o bloco abaixo
    while (n_sequencia > 0){

        // A varíavel n_atual recebe a soma de dois números da sequência
        n_atual = n_ant_1 + n_ant_2;

        // Para avançar um número na sequência, n_ant_1 passa a ter o valor de n_ant_2
        n_ant_1 = n_ant_2;

        // Também para avançar um número na sequência, n_ant_2 passa a ter o valor de n_atual
        n_ant_2 = n_atual;

        // Decrementa em um o valor da quantidade de números da sequência para o correto funcionamento do looping
        n_sequencia -= 1;

    }

    // Se o valor da sequência solicitada for igual a 1, imprime a palavra "valor" no singular
    if (n_sequencia_aux == 1){

        // Imprime na tela a soma dos valores de acordo com a quantidade solicitada
        Console.WriteLine($"A soma de {n_sequencia_aux} valor da Sequência de Fibonacci é: {n_atual - 1}.");

    }

    // Se não, imprime a palavra "valor" no plural
    else{

        // Imprime na tela a soma dos valores de acordo com a quantidade solicitada
        Console.WriteLine($"A soma de {n_sequencia_aux} valores da Sequência de Fibonacci é: {n_atual - 1}.");

    }
  }
}
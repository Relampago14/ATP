using System;

class Program{

    public static void Main(){

        // Declara as varíaveis inteiras a serem utilizadas
        int n_fatorial, n_fatorial_aux, res_fatorial = 1;

        // Imprime na tela pedindo ao usuário que digite o número que ele deseja calcular o dobro do fatorial
        Console.WriteLine("Digite o número que você deseja calcular o dobro do fatorial dele (Ex: 2 -> 2 x 2! = 4):");

        // Recebe o valor, converte para int de 32 bits e armazena na variável n_fatorial
        n_fatorial = Convert.ToInt32(Console.ReadLine());
        n_fatorial_aux = n_fatorial;

        // Enquanto n_fatorial for maior que 0, executa o bloco abaixo
        while (n_fatorial > 0){

            // A variável res_fatorial recebe o valor entre a multiplicação dela mesma com a variável n_fatorial
            res_fatorial = res_fatorial * n_fatorial;

            // A variável n_fatorial é decrementada em 1 para seguir com o loop corretamente
            n_fatorial -= 1;
        }

        // Imprime na tela o dobro do fatorial da variável 
        Console.Write($"O dobro do fatorial de {n_fatorial_aux} é: {2 * res_fatorial}");

    }

}
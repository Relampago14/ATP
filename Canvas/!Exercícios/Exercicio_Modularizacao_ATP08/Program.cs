using System;

class Program{

    // Função que recebe o número e retorna a fórmula pedida
    public static double somaNum(double n){

        return ((n * n + 1) / (n + 3));

    }

    public static double verifNum(string str_num){

    // Pega a string recebida e somente irá liberar caso a mesma possa ser convertida para inteiro

    double double_num;

    while (!(double.TryParse(str_num, out double_num))){

        Console.WriteLine("Por favor, digite um número: ");
        str_num = Console.ReadLine();

    }

    return double_num;

    }

    public static void Main(){

        string str_n;
        double n, res;

        // Recebe a entrada e converte para número
        Console.WriteLine("Digite um número: ");
        str_n = Console.ReadLine();
        n = verifNum(str_n);

        res = somaNum(n);

        Console.WriteLine($"O resultado de ({n}² + 1) / ({n} + 3) é igual a {res}");

    }

}
using System;

class Program{

    // Declara os pesos como variáveis globais
    static int p1 = 5, p2 = 3, p3 = 2;

    // Procedimento que recebe as três notas, a opção pelo tipo de média e que irá devolver os valores das médias
    public static void notaAluno(int n1, int n2, int n3, char letra, out int ma, out int mp){

        ma = 0;
        mp = 0;

        switch (letra)
        {
            case 'A':
                ma = (n1 + n2 + n3) / 3;
                break;
            case 'P':
                mp = ((n1 * p1) + (n2 * p2) + (n3 * p3)) / (p1 + p2 + p3);
                break;
            default:
                while (letra != 'A' && letra != 'P'){
                    Console.WriteLine("Por favor, digite uma opção válida: ");
                    letra = Convert.ToChar(Console.ReadLine());
                }
                break;
        }

    }

    public static int verifNum(string str_num){

    // Pega a string recebida e somente irá liberar caso a mesma possa ser convertida para inteiro

    int int_num;

    while (!(int.TryParse(str_num, out int_num))){

        Console.WriteLine("Por favor, digite um número: ");
        str_num = Console.ReadLine();

    }

    return int_num;

    }

    public static void Main(){

        string str_n_alunos, str_n1, str_n2, str_n3;
        int n_alunos, n1, n2, n3, ma, mp;
        char letra;

        // Recebe a entrada e converte para número
        Console.WriteLine("Digite o número de alunos: ");
        str_n_alunos = Console.ReadLine();
        n_alunos = verifNum(str_n_alunos);

        // Para cada aluno, executa o bloco abaixo
        for (int i = 0; i < n_alunos; i++){
            // Recebe a entrada e converte para número
            Console.WriteLine($"Digite a primeira nota do {i+1}° aluno: ");
            str_n1 = Console.ReadLine();
            n1 = verifNum(str_n1);

            // Recebe a entrada e converte para número
            Console.WriteLine($"Digite a segunda nota do {i+1}° aluno: ");
            str_n2 = Console.ReadLine();
            n2 = verifNum(str_n2);

            // Recebe a entrada e converte para número
            Console.WriteLine($"Digite a terceira nota do {i+1}° aluno: ");
            str_n3 = Console.ReadLine();
            n3 = verifNum(str_n3);

            Console.WriteLine("Agora, digite a letra 'A' para calcular a média aritimética do aluno ou "+
            "a letra 'P' para calcular a média ponderada: ");
            letra = Convert.ToChar(Console.ReadLine());

            notaAluno(n1, n2, n3, letra, out ma, out mp);

            if (letra == 'A'){
                Console.WriteLine($"A média aritimética do aluno é {ma}");
            }

            else{
                Console.WriteLine($"A média ponderada do aluno é {mp}");
            }

        }
    }

}
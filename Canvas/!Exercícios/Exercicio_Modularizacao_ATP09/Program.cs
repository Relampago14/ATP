using System;

class Program{

    public static double mediaAluno(){

        char res = ' ';
        string str_nota;
        int cont = 1, nota, notas = 0;
        double media = 0;

        while (true){

            Console.WriteLine($"Deseja digitar a {cont}° nota? (s - sim; n - não)");
            res = Console.ReadKey().KeyChar;

            // Valida as opções digitadas
            switch (res)
            {
                case 's':
                    break;
                case 'n':
                    break;
                default:
                    while (res != 's' && res != 'n'){
                        Console.WriteLine("\nPor favor, digite uma opção válida: ");
                        res = Console.ReadKey().KeyChar;
                    }
                    break;
            }

            // Se res for = 'n', encerra o loop
            if (res == 'n'){
                break;
            }

            // Recebe a entrada digitada pelo usuário e converte para inteiro
            Console.WriteLine($"\nDigite a {cont}° nota: ");
            str_nota = Console.ReadLine();
            nota = verifNum(str_nota);
            
            // Adiciona a última nota em notas
            notas += nota;

            // Faz o cálculo da média
            media = notas / cont;

            cont++;

        }

        if (media >= 6){
            return media;
        }

        else{
            return -1;
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

        double result;
        string str_n_alunos;
        int n_alunos;

        // Recebe a entrada digitada pelo usuário e converte para inteiro
        Console.WriteLine($"\nDigite o número de alunos: ");
        str_n_alunos = Console.ReadLine();
        n_alunos = verifNum(str_n_alunos);

        for (int i = 0; i < n_alunos; i++){

            result = mediaAluno();

            if (result != -1){
                Console.WriteLine($"\nA média desse aluno foi {result}. Aprovado!");
            }

            else if (result == -1){
                Console.WriteLine($"\nO aluno não alcançou a média.");
            }

            if (i + 1 != n_alunos){
                Console.WriteLine("Próximo aluno.");
            }

        }

    }

}
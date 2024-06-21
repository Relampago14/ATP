using System;

class Program{

    public static void conceitoAluno(int nota){

        // Usa a média final e compara com os valores para exibir cada conceito

        if (nota >= 90){
            Console.WriteLine("O conceito desse aluno foi 'A'. Parabéns!");
        }

        else if (nota >= 80){
            Console.WriteLine("O conceito desse aluno foi 'B'. Parabéns!");
        }

        else if (nota >= 70){
            Console.WriteLine("O conceito desse aluno foi 'C'.");
        }

        else if (nota >= 60){
            Console.WriteLine("O conceito desse aluno foi 'D'.");
        }

        else if (nota >= 40){
            Console.WriteLine("O conceito desse aluno foi 'E'.");
        }

        else{
             Console.WriteLine("O conceito desse aluno foi 'F' :(");
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

        string str_n_alunos, str_nota_aluno;
        int n_alunos, nota_aluno;

        // Recebe a entrada do usuário e converte para int
        Console.WriteLine("Digite a quantidade de alunos: ");
        str_n_alunos = Console.ReadLine();
        n_alunos = verifNum(str_n_alunos);

        // Para cada aluno, chama o procedimento acima
        for (int i = 0; i < n_alunos; i++){

            Console.WriteLine($"Digite a média final do {i+1}° aluno: ");
            str_nota_aluno = Console.ReadLine();
            nota_aluno = verifNum(str_nota_aluno);

            conceitoAluno(nota_aluno);

        }
        

    }

}
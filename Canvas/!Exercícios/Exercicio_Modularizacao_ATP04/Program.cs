using System;

class Program{

    static int l1, l2, l3;

    public static void verifTriang(int l1, int l2, int l3){

        // Recebem a validação da regra da existência do triângulo
        bool r1 = false, r2 = false, r3 = false;
        
        // Se os lados obedecerem as regras, rx = true
        if (Math.Abs(l2 - l3) < l1 && l1 < (l2 + l3)){
            r1 = true;
        }

        if (Math.Abs(l1 - l3) < l2 && l2 < (l1 + l3)){
            r2 = true;
        }

        if (Math.Abs(l1 - l2) < l3 && l3 < (l1 + l2)){
            r3 = true;
        }

        // Se todas as regras forem obedecidas, mostra se é um triângulo equilátero,
        // isósceles ou escaleno
        if (r1 && r2 && r3){
            if (l1 == l2 && l2 == l3){
                Console.Write("O triângulo formado é equilátero!");
            }

            else if (l1 == l2 || l2 == l3 || l1 == l3){
                Console.Write("O triângulo formado é isósceles!");
            }
            else{
                Console.Write("O triângulo é escaleno!");
            }
        }

        // Se nem todas as regras forem obedecidas, imprime que não é um triângulo
        else{
            Console.Write("Os lados fornecidos não formam um triângulo.");
        }

    }

    public static int verifNum(string str_l){

        int l;

        // Enquanto não for possível converter a string recebida em número, pede outra string
        while (!(int.TryParse(str_l, out l))){
            Console.WriteLine("Por favor, digite um número: ");
            str_l = Console.ReadLine();
        }

        return l;

    }

    public static void Main(){

        char res = ' ';
        string str_l1, str_l2, str_l3;

        // Loop que recebe x lados de x triângulos e somente se encerra se o usuário pressionar a tecla 'n'
        while (true){
            
            // Se for a primeira vez que é executado, deseja boas vindas
            if (res == ' '){
                Console.WriteLine("Bem vindo! Deseja verificar os três lados que você fornecer formam um triângulo? (s - sim; n - não)");
                res = Console.ReadKey().KeyChar;
            }

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
            
            // Pede o primeiro lado e verifica se o valor fornecido é um número
            Console.WriteLine("\nDigite o primeiro lado: ");
            str_l1 = Console.ReadLine();
            l1 = verifNum(str_l1);

            // Pede o segundo lado e verifica se o valor fornecido é um número
            Console.WriteLine("Digite o segundo lado: ");
            str_l2 = Console.ReadLine();
            l2 = verifNum(str_l2);

            // Pede o terceiro lado e verifica se o valor fornecido é um número
            Console.WriteLine("Digite o terceiro lado: ");
            str_l3 = Console.ReadLine();
            l3 = verifNum(str_l3);

            // Chama o procedimento e envia os três parâmetros
            verifTriang(l1, l2, l3);

            // Pergunta se o usuário quer fazer novamente
            Console.WriteLine(" Deseja fazer para outro triângulo? (s - sim; n - não)");
            res = Console.ReadKey().KeyChar;

        }

    }

}
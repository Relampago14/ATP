using System;

class Funcs{

    public static int verifNum(string str_num){

        // Pega a string recebida e somente irá liberar caso a mesma possa ser convertida para inteiro

        int int_num;

        while (!(int.TryParse(str_num, out int_num))){

            Console.WriteLine("Por favor, digite um número: ");
            str_num = Console.ReadLine();

        }

        return int_num;

    }

    public static int lerCorretoInt(string str_num){

        // Verifica se é inteiro e se é menor que o valor predefinido
        int n;

        while (true){
            n = verifNum(str_num);

            if (n <= Program.tam_motos){
                break;
            }

            Console.WriteLine($"Por favor, digite um número menor ou igual a {Program.tam_motos}: ");
            str_num = Console.ReadLine();
        }
        
        
        return n;
    }

    public static string verifMarca(string str_marca){
        // Le a marca e verifica se está entre as possíveis para retornar o valor
        string marca = "";
        switch (str_marca){
            case "1":
                marca = "Honda";
                break;
            case "2":
                marca = "Yamaha";
                break;
            case "3":
                marca = "Suzuki";
                break;
            default:
                while (str_marca != "1" && str_marca != "2" && str_marca != "3"){
                    Console.WriteLine("Por favor, digite um número entre as opções. 1 para "+
                    "Honda, 2 para Yamaha e 3 para suzuki");
                    str_marca = Console.ReadLine();
                }
                break;
        }

        return marca;
    }

    public static int verifPreco (string str_preco){

        // Verifica se o preço inserido é coerente
        int preco;

        preco = verifNum(str_preco);
        
        while (true){
            if (preco > 0){
                break;
            }
            Console.WriteLine("Por favor digite um número maior que 0: ");
            preco = verifNum(Console.ReadLine());
        }

        return preco;
    }

    public static int verifAno(string str_ano){
        // Verifica se o ano é coerente
        int ano;

        ano = verifNum(str_ano);

        while (true){
            if (ano > 1950 && ano <= 2024){
                break;
            }
            Console.WriteLine("Por favor, digite um ano coerente levando em conta o ano atual e "+
            "o ano da criação da primeira moto: ");
            ano = verifNum(Console.ReadLine());
        }

        return ano;
    }

    public static int verifCc(string str_cc){
        // Verifica se a cilindrada é coerente
        int cc;

        cc = verifNum(str_cc);

        while (true){
            if (cc > 50){
                break;
            }
            Console.WriteLine("Por favor, digite um valor de cilindrada maior que 50: ");
            cc = verifNum(Console.ReadLine());
        }

        return cc;
    }

    public static void motos_MaisDeDezMil(){
        // imprime motos
        for
            if (Program.preco[i]){

            }
    }

}
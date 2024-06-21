using System;

class Program{

    public static string calcEquacao(double a, double b, double c){

        double delta, x1, x2;
        string raizes;

        // calcula o delta
        delta = (Math.Pow(b, 2)-4*a*c);

        // Calcula "x1" se + raiz de "delta"
        x1 = (-b + (Math.Sqrt(delta))) / 2*a;

        // Calcula "x2" se - raiz de "delta"
        x2 = (-b - (Math.Sqrt(delta))) / 2*a;

        if (!(double.IsNaN(x1)) && !(double.IsNaN(x2))){
            raizes = x1 + " " + x2;
        }
        else if (double.IsNaN(x1) && !(double.IsNaN(x2))){
            raizes = Convert.ToString(x2);
        }

        else if (double.IsNaN(x2) && !(double.IsNaN(x1))){
            raizes = Convert.ToString(x1);
        }
        else{
            raizes = "erro";
        }

        return raizes;
    }

    public static void exibResult(string raizes){

        string x1 = "", x2 = "";

        // Verifica se há alguma raiz
        if (raizes != "erro"){
            // Verifica se há mais de uma raíz
            if (raizes.Contains(" ")){

                bool x1_ok = false;

                for (int i = 0; i < raizes.Length; i++){

                    
                    Console.WriteLine(raizes[i]);

                    if (raizes[i] != ' ' && !(x1_ok)){
                        x1 += raizes[i];
                    }

                    else if (raizes[i] == ' '){
                        x1_ok = true;
                    }

                    else if (raizes[i] != ' ' && x1_ok){
                        x2 += raizes[i];
                    }
                }

                Console.WriteLine($"As raízes são {x1} e {x2}");
            }
            else{
                Console.WriteLine($"A raíz é {raizes}");
            }
        }

        else{
            Console.WriteLine("Não há nenhuma raíz para essa equação");
        }
    }

    public static double verifNum(string str_num){

        // Pega a string recebida e somente irá liberar caso a mesma possa ser convertida para double

        double double_num;

        while (!(double.TryParse(str_num, out double_num))){

            Console.WriteLine("Por favor, digite um número: ");
            str_num = Console.ReadLine();

        }

        return double_num;

    }


    public static void Main(){

        double a, b, c;

        Console.WriteLine("Digite o coeficiente 'a': ");
        a = verifNum(Console.ReadLine());

        Console.WriteLine("Digite o coeficiente 'b': ");
        b = verifNum(Console.ReadLine());

        Console.WriteLine("Digite o coeficiente 'c': ");
        c = verifNum(Console.ReadLine());

        exibResult(calcEquacao(a, b, c));

    }

}

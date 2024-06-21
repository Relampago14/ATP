using System;

class Program{

    public static int quant_Algarism(string str_n){

        int int_n, length_n = 0;

        if (int.TryParse(str_n, out int_n)){

            length_n = str_n.Length;
            
        }

        return length_n;

    }

    public static void Main(){
        string n = Console.ReadLine();
        int len_n = quant_Algarism(n);

        if (len_n == 0){
            Console.Write($"{n} não é numero");
        }
        else{
            Console.Write($"{n} tem {len_n} quantidades de algarismos");
        }
    }

}
using System;

class Program{

    public static void Main(){

        double n1, n2, n3;

        Console.Write("Informe um número: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe mais um número: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe outro número: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("A média aritmética desses três números é: "+((n1+n2+n3)/3));

    }

}
using System;

public class Program{
    public static void Main(){

        Double sm, kW, p_kW;

        Console.Write("Insira o valor do salário-mínimo: ");
        sm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira o valor do consumo da residência em kilowatts: ");
        kW = Convert.ToDouble(Console.ReadLine());

        p_kW = sm/7/100;

        Console.Write($"O valor de cada kilowatt é R$ {p_kW:0.00}, o valor da conta a ser paga é R$ {p_kW * kW:0.00}, porém com desconto é R$ {p_kW * kW - (p_kW * kW * 0.1):0.00}");
        
    }
}
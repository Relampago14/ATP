// using System;

// class Program{

//     static int a(int a_1, int a_2, int a_3){
//         a_3 = a_1 + a_2;

//         return a_3;
//     }

//     static int b(int a_1, int a_2){
//         return a_1 + a_2;
//     }

//     static void c(int a_1, int a_2, int a_3){
//         // Gambiarra

//         a_3 = a_1 + a_2;

//         print(a_3)
//     }

//     static void d(int a_1, int a_2, out int a_3){
//         a_3 = a_1 + a_2;
//     }

//     static void e(int a_1, int a_2, ref int a_3){
//         a_3 = a_1 + a_2;
//     }

//     static void f(ref int a_1, ref int a_2, ref int a_3){
//         a_3 = a_1 + a_2;
//     }

//     static void g(out int a_1, out int a_2, out int a_3){
//         // Gambiarra

//         Console.WriteLine('Digite o primeiro valor');
//         a_1 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine('Digite o segundo valor');
//         a_2 = Convert.ToInt32(Console.ReadLine());

//         a_3 = a_1 + a_2;
//     }

//     static int h(out int a_1, out int a_2){
//         // Gambiarra

//         Console.WriteLine('Digite o primeiro valor');
//         a_1 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine('Digite o segundo valor');
//         a_2 = Convert.ToInt32(Console.ReadLine());

//         return a_1 + a_2;
//     }

//     static int i(ref int a_1, ref int a_2){
//         return a_1 + a_2;
//     }


// }

using System;

class Program{

    public static void Dobrar(ref int n){

        n *= 2;
        Console.WriteLine(n);

    }

    public static void Main(){

        int num = 10;
        Dobrar(ref num);

        Console.WriteLine("teste " + num);

    }

}
using System;

class Program{

    public static int inc(int a){
        return a + 1;
    }

    public static int dec(int a){
        return a - 1;
    }

    public static int soma(int a, int b){
        while (a > 0){
            a = dec(a);
            b = inc(b);
        }
        return b;
    }

    public static int sub(int a, int b){
        int c = 0;
        while (a > 0 || b > 0){
            a = dec(a);
            b = dec(b);
            if (a == 0 || b == 0){
                break;
            }
        }

        if (a > b){
            c = a;
        }
        else if(a < b){
            c = b;
        }
        else if(a == b){
            c = a;
        }

        return c;

    }

    public static void Main(){
            int subtr = sub(1, 5);
            Console.WriteLine(subtr);
        }

}
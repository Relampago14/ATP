using System;
class Program{

    public static int tam_motos = 3;
    public static string[] marca = new string[tam_motos];
    public static string[] modelo = new string[tam_motos];
    public static double[] preco = new double[tam_motos];
    public static int[] ano = new int[tam_motos];
    public static int[] cc = new int[tam_motos];

    public static void Main(){

        string str_n_cadastros;
        int n_cadastros; 

        // Lê a quantidade de motos que serão cadastradas e verifica se bate
        Console.WriteLine("Insira a quantidade de motos que serão cadastradas "+
        $"(o máximo são {tam_motos} unidades): ");
        str_n_cadastros = Console.ReadLine();
        n_cadastros = Funcs.lerCorretoInt(str_n_cadastros);

        // Le as características das motos e lança no array motos
        while (true){
          for (int i = 0; i < n_cadastros; i++){
            Console.WriteLine("Digite a marca da moto (1 - Honda, 2 - Yamaha ou "+
            "3 - Suzuki): ");
            marca[i] = Funcs.verifMarca(Console.ReadLine());
            
            Console.WriteLine("Agora informe o modelo da moto: ");
            modelo[i] = Console.ReadLine();

            Console.WriteLine("Digite o preço dessa moto: ");
            preco[i] = Funcs.verifPreco(Console.ReadLine());

            Console.WriteLine("Digite o ano dessa moto: ");
            ano[i] = Funcs.verifAno(Console.ReadLine());

            Console.WriteLine("Por fim, digite as cilindradas da moto: ");
            cc[i] = Funcs.verifCc(Console.ReadLine());

            // Pergunta se o usuário deseja continuar
            Console.WriteLine("Deseja continuar com o cadastro? 'S'-sim Qualquer outro-não");
            string resposta = Console.ReadLine();

            if (resposta != "S"){
              break;
            }
          }
        }

    }

}
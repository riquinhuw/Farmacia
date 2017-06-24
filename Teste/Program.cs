using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] remedioNome = new string[11]; //Neusadina 40g
            string[] remedioDescricao = new string[11]; //Para dores de cabecas
            int[] remedioNumero = new int[11]; // Numeração para identificação
            int[] remedioQuantidade = new int[11]; //Quantidade em estoque
            string[] remedioPrevisao = new string[11]; // Previsão de quando vai voltar
            double[] remedioPreco = new double[11]; //Preço
            string[] remedioSintoma = new string[11];// dor - rim - meu deus


            int i = 0;
            for (; i < 10; i++) { Console.WriteLine(i); }

            i = 0;
            for (i = 0; i <= 11 - 1; i++)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",remedioNome[i],remedioQuantidade[i],remedioPreco[i],remedioPrevisao[i]);

            }

        }
    



    /*public static int i = 0;
    public static float[] nomes = new float[5] ;
    public static string[] nomess = new string[5];

    static void Main(string[] args)
    {
        int[] numero = new int[11];
        int i;
        int contador = 0;
        int[] qtd = new int[11];

        for (i = 0; i <3; i++){
            numero[i] = int.Parse(Console.ReadLine());

        }
        for (i = 0; i < 3; i++){
            qtd[i] = int.Parse(Console.ReadLine());

        }
        for (i = 0; i < 11; i++){

            contador = contador + (numero[i] * qtd[i]);
        }

        Console.WriteLine(contador);

    */

    /*
    double numero;
    numero = 14.50;

    Ler();
    i = 0;
    for (; i < 5; i++)
    {
        nomess[i] = Convert.ToString(numero);
    }
    System.IO.File.WriteAllLines (@"E:\textos\WriteLines.txt", nomess);


}

static void Ler()
{
    for (; i < 5; i++)
    {
        nomes[i] = float.Parse(Console.ReadLine());
    }*/
} 
    }


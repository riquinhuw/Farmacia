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
        public static int i = 0;
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
}

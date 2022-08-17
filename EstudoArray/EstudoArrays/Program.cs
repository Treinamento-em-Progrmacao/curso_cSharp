using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] arrInt = new int[10];
            //arrInt[0] = 2; // O valor 2 vai para dentro da primeira posição do array
            //arrInt[2] = 4; // O valor 4 vai para dentro da última posição do array
            //Console.WriteLine("O primeiro número do array é {0}", arrInt[0]);
            //Console.WriteLine("O último número do array é {0}", arrInt[2]);
            //Console.WriteLine("Tamanho = " + arrInt.Length.ToString());
            //int[] m = { 1, 2, 3, 7, 4, 5, 6, 8, 9 };
            //int i = Array.IndexOf(m, 7);
            //Console.WriteLine("Posição i = " + i.ToString());

            int[,] matriz = new int[2, 2];

            matriz[0, 0] = 3;
            matriz[1, 1] = 5;
            Console.WriteLine("A primeira posição da primeira linha é {0}", matriz[0, 0]);
            Console.WriteLine("A última posição da última linha é {0}", matriz[1, 1]);







            Console.ReadKey();



        }
    }
}

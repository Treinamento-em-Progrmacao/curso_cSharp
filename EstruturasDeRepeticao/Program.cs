using System;

namespace EstruturasDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For
            // Foreach /in
            // While
            // Do /while

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("teste do laço for = {0}", i);

            //    if (i == 3)
            //        continue;
            //    /* a declaração a seguir não será executada quando i==3, porém, o for será "chamado" novamente, incrementando o valor de i */
            //    Console.WriteLine("iteração número {0}", i + 2);


            // }

            //int[] j = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (var item in j)
            //{
            //    Console.WriteLine("Retornado itens de foreach = {0}", item);
            //}


            int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine("teste do laço while = {0}", i);

            //    i++;
            //}

            do
            {
                Console.WriteLine("teste do laço do while = {0}", i);

                i++;

                if (i > 5)
                    break;


            } while (i <= 10);

           












        }
    }
}

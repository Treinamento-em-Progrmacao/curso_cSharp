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

            for (int i = 0; i <= 5; i++)
            {
               Console.WriteLine("Teste do laço FOR = {0}", i);

                if (i == 3)
                    continue;
                /* A declaração a seguir não será executada quando i==3, porém, o for será "chamado" novamente, incrementando o valor de i */
                Console.WriteLine("Iteração número {0}", i + 2);


            }

        }
    }
}

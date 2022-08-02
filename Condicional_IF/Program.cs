using System;

namespace Condicional_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = 2;
            int b = 1;

            if (a < b)
            {
                Console.WriteLine("B é maior");
                Console.ReadKey();
               
            }
            else if(a > b)
            {
                Console.WriteLine("A é maior");
                Console.ReadKey();
            }
            else if (a == b)
            {
                Console.WriteLine("A é maior");
                Console.ReadKey();
            }



        }
    }
}

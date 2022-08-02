using System;

namespace testeswit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            compInt(num1,num2);

            //switch (compInt(num1, num2))
            //{
            //    case 0:
            //        Console.WriteLine("A é igual a B");
            //        break;
            //    case 1:
            //        Console.WriteLine("A é maior do que B");
            //        break;
            //    default:
            //        Console.WriteLine("A é menor do que B");
            //        break;
            //}



            void compInt(int num1, int num2)
            {
                if (num1 == num2)
                {
                    Console.WriteLine("Numeros sao iguais!");
                    //return 0;
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("Numeros 1 é menor!");
                   // return -1;
                }
                else
                {
                    Console.WriteLine("Numeros 2 é maior!");
                    //return 1; // num1 > num2
                }
            }
        }



    }
}

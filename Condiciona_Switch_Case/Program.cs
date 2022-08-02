using System;

namespace Condiciona_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            static int retornaUmValor(int num1, int num2)
            {
                if(num1 == num2)
                {
                    return 0;
                }else if(num1 < num2)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }

            switch (retornaUmValor(20, 20))
            { 
                case 0:
                    Console.WriteLine("A é igual a B ");
                    break;
                    case -1:
                    Console.WriteLine("A é menor do que B ");
                    break;
                    case 1:
                    Console.WriteLine("A é maior do que B  ");
                    break;
                    default:
                    Console.WriteLine("Não atendeu a nenhum metodo acima! ");
                    break;



            }



        }
    }
}

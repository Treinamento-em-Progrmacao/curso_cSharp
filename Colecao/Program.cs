using System;
using System.Collections.Generic;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                //int[] numerosDigitado = new int[10];

                //for( int i = 0; i < numerosDigitado.Length; i++)
                //{
                //    Console.WriteLine("Digite o número {0}: ", i + 1);
                //    numerosDigitado[i] = Convert.ToInt32(Console.ReadLine());

                //}

                var numerosDigitadoList = new List<int>();

                bool continuarLer = true;

                while (continuarLer)
                {
                    Console.WriteLine("digite um número: ");

                    string dadoDigitado = Console.ReadLine();

                    if (dadoDigitado.Equals("sair"))
                    {
                        continuarLer = false;
                    }
                    else
                    {
                        numerosDigitadoList.Add(int.Parse(dadoDigitado));
                    }

                }

                for (var i = 0; i < numerosDigitadoList.Count; i++)
                {
                    Console.WriteLine("Lista de numeros é = {0}", numerosDigitadoList[i]);
                }

                Console.ReadKey();


            
        }
    }
}

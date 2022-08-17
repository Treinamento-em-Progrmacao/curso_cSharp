using System;
using System.Collections.Generic;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region aula1

            //int[] numerosDigitado = new int[10];

            //for( int i = 0; i < numerosDigitado.Length; i++)
            //{
            //    Console.WriteLine("Digite o número {0}: ", i + 1);
            //    numerosDigitado[i] = Convert.ToInt32(Console.ReadLine());

            //}

            #endregion

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


                    Console.WriteLine("Digite um numero para ser removido : ");

                     string num = Console.ReadLine();

                    numerosDigitadoList.Remove(Convert.ToInt32(num));


                for (var i = 0; i < numerosDigitadoList.Count; i++)
                {
                    Console.WriteLine("Lista com numero removido é = {0}", numerosDigitadoList[i]);
                }


            Console.WriteLine("Digite um índice para ser removido : ");

            string indice = Console.ReadLine();
           
            numerosDigitadoList.RemoveAt(Convert.ToInt32(indice));

            for (var i = 0; i < numerosDigitadoList.Count; i++)
            {
                Console.WriteLine("Lista com índice removido é = {0}", numerosDigitadoList[i]);
            }

            


            Console.ReadKey();

           



        }
    }
}

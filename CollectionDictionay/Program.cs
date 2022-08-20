using System;
using System.Collections.Generic;

namespace CollectionDictionay
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //List<string> ListaNumeros = new List<string>();


            Dictionary<int, string> ListDictionary = new Dictionary<int, string>();

            ListDictionary.Add(1, "Antonio Henriques");
            ListDictionary.Add(2, "Maria José");


            foreach(int key in ListDictionary.Keys)
            {

                Console.WriteLine("{0} = {1}", key, ListDictionary[key]);

            }

            Console.ReadKey();
           
            


        }
    }
}

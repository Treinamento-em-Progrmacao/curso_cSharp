using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoDeErros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\teste\teste.txt");
            string linha;            
           

            while ((linha = stream.ReadLine()) != null)
            {
                Console.WriteLine(linha);
               
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentosDeErros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader stream = new StreamReader(@"C:\teste\teste\teste.txt");

                string linha;
                while ((linha = stream.ReadLine()) != null)
                {
                    Console.WriteLine(linha);

                }

                Console.ReadKey();


            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("Sem memória para criação do buffer...!", e.Message);
                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine("O Arquivo não exite nesse caminho!", e.Message);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro desconhecido!", e.Message);
                Console.ReadKey();
            }

            
               
                              




        }
    }
}

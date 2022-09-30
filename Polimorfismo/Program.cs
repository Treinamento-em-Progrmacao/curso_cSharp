using System;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pai pai = new Pai();
            Filha filha = new Filha();
            Filha2 filha2 = new Filha2();            

            pai.Confirmar(); //"Classe Pai = Apertou botão OK e abriu lista de canais!"
            filha.Confirmar(); //"Classe filha = apertou botão ok e Selecionou o canal!"

            string can = filha.SelecionaCanal("2");
            Console.WriteLine("Canal = {0} ", can.ToString());

            filha2.Confirmar();//"Classe filha2 = Apertou o botão Ok e confirmou o canal!"

           

        }
    }
}

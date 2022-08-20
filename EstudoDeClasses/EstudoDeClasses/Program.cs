using System;


namespace EstudoDeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c6 = new Carro
            {
                Nome = "Gol",
                Marca = "Fiat",
                TotalDePortas = 4


            };

            Carro c1 = new Carro();
            Carro c2 = new Carro();
            Carro c3 = new Carro();
            Carro c4 = new Carro("Gol");
            Carro c5 = new Carro(4,"Honda");
            Carro c7 = new Carro();
          
           

            c1.Marca = "Fiat";
            c2.Marca = "Toyota";
            c3.Marca = "Hyndai";

            
            c1.AdicionarUltimosDonos("Antonio Henriques");
            c1.AdicionarUltimosDonos("Maria José");
            c1.AdicionarUltimosDonos("José Mario");
            c1.AdicionarUltimosDonos("Mario Henrique");


            Console.WriteLine("A marca de c1 é = {0} ", c1.Marca);
            Console.WriteLine("A marca de c2 é = {0} ", c2.Marca);
            Console.WriteLine("A marca de c3 é = {0} ", c3.Marca);
            Console.WriteLine("O nome de  c4 é = {0} ", c4.Nome);
            Console.WriteLine("O Carro tem {0} portas e é da marca {1} ", c5.TotalDePortas, c5.Marca);
            Console.WriteLine("O Carro tem {0} portas e é da marca {1} e nome {2} ", c6.TotalDePortas, c6.Marca, c6.Nome);
            Console.WriteLine(c7.PartirComCarro(3));
            

            foreach(string c in c1.GetUltimosDonos())
            {
                Console.WriteLine("Um dos ultimos dono é c1 é = {0} ", c);
            }

            Console.ReadKey();

           
           

        }
    }
}

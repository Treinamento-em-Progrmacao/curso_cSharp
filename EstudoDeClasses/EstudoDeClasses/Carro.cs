using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDeClasses
{
    public class Carro
    {
        public Carro()
        {
            this.UltimosDonos = new List<string>();
            this.Marca = "Honda";
        }
        public Carro(string nome)
        {
            this.Nome = nome;
                
        }
       public Carro(int totalDePortas, string marca) 
        {           
            TotalDePortas = totalDePortas;           
            Marca = marca;
        }

        private string marca;
        private List<string> UltimosDonos;
        public int TotalDePortas { get; set; }
        public string Nome { get; set; }

        public string Marca 
        {
            get 
            {
                return marca;
            }
            set 
            {
                if(value == "Fiat")
                {
                    marca = "Ford";
                }
                else
                {
                    marca = value;
                }                          
            
            }
        }     


        public void AdicionarUltimosDonos(string nome)
        {

            UltimosDonos.Add(nome);

        }

        public List<string> GetUltimosDonos()
        {

            return UltimosDonos;
        }


        public string PartirComCarro()
        {
            return "Vocçê partiu com o carro de 1ª marcha!";
        }

        public string PartirComCarro(int marcha)
        {
            
            return "Vocçê partiu com o carro de" + marcha +"ª" + "marcha!";
        }










    }
}

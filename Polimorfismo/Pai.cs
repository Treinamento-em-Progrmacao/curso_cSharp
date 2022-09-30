using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Pai
    {

        public string status { get; set; }
        public string  canal { get; set; }


        public virtual string SelecionaCanal(string canal)
        {
            if (canal == "0")
            {
                return "Nenhum canal selecionado!";
            }

            return canal;

        }

        public virtual void Confirmar()
        {
            this.status = "Classe Pai = Apertou botão OK e abriu lista de canais!";

            Console.WriteLine(this.status);
        }


    }
}

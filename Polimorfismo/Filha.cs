using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Filha: Pai
    {
       
        public override void Confirmar()
        {
            this.status = "Classe filha = apertou botão ok e Selecionou o canal!";

            Console.WriteLine(this.status);

        }

        public override string SelecionaCanal(string canal)
        {
            return base.SelecionaCanal(canal);
        }
    }
}
